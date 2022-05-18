using Newtonsoft.Json;
using System.Xml.Serialization;

namespace HumanResources_net6
{
	enum SerializeMode
	{
		XML, JSON
	}

	class FileSerializer<T> where T : new()
	{
		private readonly SerializeMode _serializeMode;

		private readonly string _filePath;

		public FileSerializer(SerializeMode serializeMode, string filePath)
		{
			_serializeMode = serializeMode;
			_filePath = filePath;
		}

		public void Serialize(T item)
		{
			var directoryName = Path.GetDirectoryName(_filePath);					
			if (!Directory.Exists(directoryName))
				Directory.CreateDirectory(directoryName);

			switch (_serializeMode)
			{
				case SerializeMode.XML:
					using (var streamWriter = new StreamWriter(_filePath))
					{
						var serializer = new XmlSerializer(typeof(T));
						serializer.Serialize(streamWriter, item);
					}
					break;
				case SerializeMode.JSON:
					var json = JsonConvert.SerializeObject(item, Formatting.Indented); //serializacja
					File.WriteAllText(_filePath, json); //zapis do pliku
					break;
			}
		}

		public T Deserialize()
		{
			if (File.Exists(_filePath))
			{
				switch (_serializeMode)
				{
					case SerializeMode.XML:
						using (var streamReader = new StreamReader(_filePath))
						{
							var serializer = new XmlSerializer(typeof(T));
							return (T)serializer.Deserialize(streamReader);
						}
					case SerializeMode.JSON:
						var json = File.ReadAllText(_filePath); //odczyt z pliku
						return JsonConvert.DeserializeObject<T>(json); //deserializacja
				}
			}
			return new T();
		}
	}
}
