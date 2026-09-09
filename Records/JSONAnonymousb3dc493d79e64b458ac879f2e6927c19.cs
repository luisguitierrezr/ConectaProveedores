using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FiscalYearExceptionsRecord
public class JSONRC_341c7b677aa5a51a40f72189133871ba : AbstractRESTStructure<RC_341c7b677aa5a51a40f72189133871ba> {
[JsonProperty("FiscalYearExceptions")]
[JsonPropertyName("FiscalYearExceptions")]
public ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord AttrFiscalYearExceptions;

public JSONRC_341c7b677aa5a51a40f72189133871ba() { }

public JSONRC_341c7b677aa5a51a40f72189133871ba (RC_341c7b677aa5a51a40f72189133871ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFiscalYearExceptions = ConvertToRestWithoutDefaults(s.ssENFiscalYearExceptions, new EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord.FromStructure, config);
  } else {
AttrFiscalYearExceptions = ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord.FromStructure(s.ssENFiscalYearExceptions, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_341c7b677aa5a51a40f72189133871ba, RC_341c7b677aa5a51a40f72189133871ba> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_341c7b677aa5a51a40f72189133871ba s) => ToStructure(s, config);
}
public static RC_341c7b677aa5a51a40f72189133871ba ToStructure(ssConectaProveedores.RestRecords.JSONRC_341c7b677aa5a51a40f72189133871ba obj, IBehaviorsConfiguration config) { 
  RC_341c7b677aa5a51a40f72189133871ba s = new RC_341c7b677aa5a51a40f72189133871ba();
  if(obj != null) {
  s.ssENFiscalYearExceptions = ssConectaProveedores.RestRecords.JSONEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord.ToStructure(obj.AttrFiscalYearExceptions, config);
  }
  return s;
}

public static Func<RC_341c7b677aa5a51a40f72189133871ba, ssConectaProveedores.RestRecords.JSONRC_341c7b677aa5a51a40f72189133871ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_341c7b677aa5a51a40f72189133871ba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_341c7b677aa5a51a40f72189133871ba FromStructure(RC_341c7b677aa5a51a40f72189133871ba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_341c7b677aa5a51a40f72189133871ba(s, config);
}

}


