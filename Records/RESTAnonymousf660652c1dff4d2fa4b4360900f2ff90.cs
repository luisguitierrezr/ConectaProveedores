using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// AccordionIconPositionRecord
public class RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 : AbstractRESTStructure<RC_ab72f035aa34ddb5ec313dc02adb1f18> {
[JsonProperty("AccordionIconPosition")]
public ssConectaProveedores.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord AttrAccordionIconPosition;

public RESTRC_ab72f035aa34ddb5ec313dc02adb1f18() { }

public RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 (RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrAccordionIconPosition = ConvertToRestWithoutDefaults(s.ssENAccordionIconPosition, new EN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructure, config);
  } else {
AttrAccordionIconPosition = ssConectaProveedores.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.FromStructure(s.ssENAccordionIconPosition, config);
  }
}

public static RC_ab72f035aa34ddb5ec313dc02adb1f18 ToStructure(ssConectaProveedores.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 obj) { 
  RC_ab72f035aa34ddb5ec313dc02adb1f18 s = new RC_ab72f035aa34ddb5ec313dc02adb1f18();
  if(obj != null) {
  s.ssENAccordionIconPosition = ssConectaProveedores.RestRecords.RESTEN_7f8fd02aa7ee2ac6182b6b36e46460d9EntityRecord.ToStructure(obj.AttrAccordionIconPosition);
  }
  return s;
}

public static Func<RC_ab72f035aa34ddb5ec313dc02adb1f18, ssConectaProveedores.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_ab72f035aa34ddb5ec313dc02adb1f18 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18 FromStructure(RC_ab72f035aa34ddb5ec313dc02adb1f18 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_ab72f035aa34ddb5ec313dc02adb1f18(s, config);
}

}


