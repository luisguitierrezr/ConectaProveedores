using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FiscalYearExceptionsRecord
public class RESTRC_341c7b677aa5a51a40f72189133871ba : AbstractRESTStructure<RC_341c7b677aa5a51a40f72189133871ba> {
[JsonProperty("FiscalYearExceptions")]
public ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord AttrFiscalYearExceptions;

public RESTRC_341c7b677aa5a51a40f72189133871ba() { }

public RESTRC_341c7b677aa5a51a40f72189133871ba (RC_341c7b677aa5a51a40f72189133871ba s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFiscalYearExceptions = ConvertToRestWithoutDefaults(s.ssENFiscalYearExceptions, new EN_d4d76c9b70434c39cd4ba42065870f95EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord.FromStructure, config);
  } else {
AttrFiscalYearExceptions = ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord.FromStructure(s.ssENFiscalYearExceptions, config);
  }
}

public static RC_341c7b677aa5a51a40f72189133871ba ToStructure(ssConectaProveedores.RestRecords.RESTRC_341c7b677aa5a51a40f72189133871ba obj) { 
  RC_341c7b677aa5a51a40f72189133871ba s = new RC_341c7b677aa5a51a40f72189133871ba();
  if(obj != null) {
  s.ssENFiscalYearExceptions = ssConectaProveedores.RestRecords.RESTEN_d4d76c9b70434c39cd4ba42065870f95EntityRecord.ToStructure(obj.AttrFiscalYearExceptions);
  }
  return s;
}

public static Func<RC_341c7b677aa5a51a40f72189133871ba, ssConectaProveedores.RestRecords.RESTRC_341c7b677aa5a51a40f72189133871ba> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_341c7b677aa5a51a40f72189133871ba s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_341c7b677aa5a51a40f72189133871ba FromStructure(RC_341c7b677aa5a51a40f72189133871ba s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_341c7b677aa5a51a40f72189133871ba(s, config);
}

}


