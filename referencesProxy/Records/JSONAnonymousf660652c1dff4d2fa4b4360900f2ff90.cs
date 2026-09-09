using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// AccordionIconPositionRecord
public class JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 : AbstractRESTStructure<RC_ab72f035aa34ddb5ec313dc02adb1f18> {
[JsonProperty("AccordionIconPosition")]
[JsonPropertyName("AccordionIconPosition")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord AttrAccordionIconPosition;

public JSONRC_ab72f035aa34ddb5ec313dc02adb1f18() { }

public JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 (RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordionIconPosition = ConvertToRestWithoutDefaults(s.ssENAccordionIconPosition, new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructure, config);
  } else {
AttrAccordionIconPosition = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructure(s.ssENAccordionIconPosition, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18, RC_ab72f035aa34ddb5ec313dc02adb1f18> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 s) => ToStructure(s, config);
}
public static RC_ab72f035aa34ddb5ec313dc02adb1f18 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 obj, IBehaviorsConfiguration config) { 
  RC_ab72f035aa34ddb5ec313dc02adb1f18 s = new RC_ab72f035aa34ddb5ec313dc02adb1f18();
  if(obj != null) {
  s.ssENAccordionIconPosition = ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.ToStructure(obj.AttrAccordionIconPosition, config);
  }
  return s;
}

public static Func<RC_ab72f035aa34ddb5ec313dc02adb1f18, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab72f035aa34ddb5ec313dc02adb1f18 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18 FromStructure(RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_ab72f035aa34ddb5ec313dc02adb1f18(s, config);
}

}


