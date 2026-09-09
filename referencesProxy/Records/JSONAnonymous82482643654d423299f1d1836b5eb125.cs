using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.ReferencesProxy.RestRecords;

// T_FAC_PAG_OutRecord
public class JSONRC_5506eaadd5156d49feef98fb7105f829 : AbstractRESTStructure<RC_5506eaadd5156d49feef98fb7105f829> {
[JsonProperty("T_FAC_PAG_Out")]
[JsonPropertyName("T_FAC_PAG_Out")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure AttrT_FAC_PAG_Out;

public JSONRC_5506eaadd5156d49feef98fb7105f829() { }

public JSONRC_5506eaadd5156d49feef98fb7105f829 (RC_5506eaadd5156d49feef98fb7105f829 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrT_FAC_PAG_Out = ConvertToRestWithoutDefaults(s.ssSTT_FAC_PAG_Out, new ST_99acd807840db0272ca95b7e5ca3fca1Structure(), ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure.FromStructure, config);
  } else {
AttrT_FAC_PAG_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure.FromStructure(s.ssSTT_FAC_PAG_Out, config);
  }
}

public static Func<ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5506eaadd5156d49feef98fb7105f829, RC_5506eaadd5156d49feef98fb7105f829> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5506eaadd5156d49feef98fb7105f829 s) => ToStructure(s, config);
}
public static RC_5506eaadd5156d49feef98fb7105f829 ToStructure(ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5506eaadd5156d49feef98fb7105f829 obj, IBehaviorsConfiguration config) { 
  RC_5506eaadd5156d49feef98fb7105f829 s = new RC_5506eaadd5156d49feef98fb7105f829();
  if(obj != null) {
  s.ssSTT_FAC_PAG_Out = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_99acd807840db0272ca95b7e5ca3fca1Structure.ToStructure(obj.AttrT_FAC_PAG_Out, config);
  }
  return s;
}

public static Func<RC_5506eaadd5156d49feef98fb7105f829, ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5506eaadd5156d49feef98fb7105f829> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_5506eaadd5156d49feef98fb7105f829 s) => FromStructure(s, config);
}
public static ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5506eaadd5156d49feef98fb7105f829 FromStructure(RC_5506eaadd5156d49feef98fb7105f829 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.ReferencesProxy.RestRecords.JSONRC_5506eaadd5156d49feef98fb7105f829(s, config);
}

}


