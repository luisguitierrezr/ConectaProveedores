using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationPeriodRecord
public class JSONRC_8c5142d0fa3763f0e03a67182ad7f367 : AbstractRESTStructure<RC_8c5142d0fa3763f0e03a67182ad7f367> {
[JsonProperty("DocumentExtrationPeriod")]
[JsonPropertyName("DocumentExtrationPeriod")]
public ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure AttrDocumentExtrationPeriod;

public JSONRC_8c5142d0fa3763f0e03a67182ad7f367() { }

public JSONRC_8c5142d0fa3763f0e03a67182ad7f367 (RC_8c5142d0fa3763f0e03a67182ad7f367 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationPeriod = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationPeriod, new ST_3071806a59ac2d49d464c40254dbb5f2Structure(), ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure.FromStructure, config);
  } else {
AttrDocumentExtrationPeriod = ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure.FromStructure(s.ssSTDocumentExtrationPeriod, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8c5142d0fa3763f0e03a67182ad7f367, RC_8c5142d0fa3763f0e03a67182ad7f367> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8c5142d0fa3763f0e03a67182ad7f367 s) => ToStructure(s, config);
}
public static RC_8c5142d0fa3763f0e03a67182ad7f367 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8c5142d0fa3763f0e03a67182ad7f367 obj, IBehaviorsConfiguration config) { 
  RC_8c5142d0fa3763f0e03a67182ad7f367 s = new RC_8c5142d0fa3763f0e03a67182ad7f367();
  if(obj != null) {
  s.ssSTDocumentExtrationPeriod = ssConectaProveedores.RestRecords.JSONST_3071806a59ac2d49d464c40254dbb5f2Structure.ToStructure(obj.AttrDocumentExtrationPeriod, config);
  }
  return s;
}

public static Func<RC_8c5142d0fa3763f0e03a67182ad7f367, ssConectaProveedores.RestRecords.JSONRC_8c5142d0fa3763f0e03a67182ad7f367> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8c5142d0fa3763f0e03a67182ad7f367 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8c5142d0fa3763f0e03a67182ad7f367 FromStructure(RC_8c5142d0fa3763f0e03a67182ad7f367 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8c5142d0fa3763f0e03a67182ad7f367(s, config);
}

}


