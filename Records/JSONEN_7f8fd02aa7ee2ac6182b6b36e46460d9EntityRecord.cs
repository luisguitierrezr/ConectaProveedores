using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccordionIconPosition
public class JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord : AbstractRESTStructure<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> {
[JsonProperty("Label")]
[JsonPropertyName("Label")]
public string AttrLabel;

public JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord() { }

public JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrLabel = s.ssLabel;
  } else {
AttrLabel = s.ssLabel;
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord, EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord s) => ToStructure(s, config);
}
public static EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord ToStructure(ssConectaProveedores.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord obj, IBehaviorsConfiguration config) { 
  EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord s = new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord();
  if(obj != null) {
  s.ssLabel = obj.AttrLabel == null ? "" : obj.AttrLabel;
  }
  return s;
}

public static Func<EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord, ssConectaProveedores.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord FromStructure(EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord(s, config);
}

}


