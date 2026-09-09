using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// DocumentExtrationPeriodRecord
public class RESTRC_8c5142d0fa3763f0e03a67182ad7f367 : AbstractRESTStructure<RC_8c5142d0fa3763f0e03a67182ad7f367> {
[JsonProperty("DocumentExtrationPeriod")]
public ssConectaProveedores.RestRecords.RESTST_3071806a59ac2d49d464c40254dbb5f2Structure AttrDocumentExtrationPeriod;

public RESTRC_8c5142d0fa3763f0e03a67182ad7f367() { }

public RESTRC_8c5142d0fa3763f0e03a67182ad7f367 (RC_8c5142d0fa3763f0e03a67182ad7f367 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrDocumentExtrationPeriod = ConvertToRestWithoutDefaults(s.ssSTDocumentExtrationPeriod, new ST_3071806a59ac2d49d464c40254dbb5f2Structure(), ssConectaProveedores.RestRecords.RESTST_3071806a59ac2d49d464c40254dbb5f2Structure.FromStructure, config);
  } else {
AttrDocumentExtrationPeriod = ssConectaProveedores.RestRecords.RESTST_3071806a59ac2d49d464c40254dbb5f2Structure.FromStructure(s.ssSTDocumentExtrationPeriod, config);
  }
}

public static RC_8c5142d0fa3763f0e03a67182ad7f367 ToStructure(ssConectaProveedores.RestRecords.RESTRC_8c5142d0fa3763f0e03a67182ad7f367 obj) { 
  RC_8c5142d0fa3763f0e03a67182ad7f367 s = new RC_8c5142d0fa3763f0e03a67182ad7f367();
  if(obj != null) {
  s.ssSTDocumentExtrationPeriod = ssConectaProveedores.RestRecords.RESTST_3071806a59ac2d49d464c40254dbb5f2Structure.ToStructure(obj.AttrDocumentExtrationPeriod);
  }
  return s;
}

public static Func<RC_8c5142d0fa3763f0e03a67182ad7f367, ssConectaProveedores.RestRecords.RESTRC_8c5142d0fa3763f0e03a67182ad7f367> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8c5142d0fa3763f0e03a67182ad7f367 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_8c5142d0fa3763f0e03a67182ad7f367 FromStructure(RC_8c5142d0fa3763f0e03a67182ad7f367 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_8c5142d0fa3763f0e03a67182ad7f367(s, config);
}

}


