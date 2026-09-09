using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFilesRecord
public class JSONRC_28fdb7a8aef891dc921c5fe34393a569 : AbstractRESTStructure<RC_28fdb7a8aef891dc921c5fe34393a569> {
[JsonProperty("FolioFiles")]
[JsonPropertyName("FolioFiles")]
public ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

public JSONRC_28fdb7a8aef891dc921c5fe34393a569() { }

public JSONRC_28fdb7a8aef891dc921c5fe34393a569 (RC_28fdb7a8aef891dc921c5fe34393a569 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
  } else {
AttrFolioFiles = ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_28fdb7a8aef891dc921c5fe34393a569, RC_28fdb7a8aef891dc921c5fe34393a569> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_28fdb7a8aef891dc921c5fe34393a569 s) => ToStructure(s, config);
}
public static RC_28fdb7a8aef891dc921c5fe34393a569 ToStructure(ssConectaProveedores.RestRecords.JSONRC_28fdb7a8aef891dc921c5fe34393a569 obj, IBehaviorsConfiguration config) { 
  RC_28fdb7a8aef891dc921c5fe34393a569 s = new RC_28fdb7a8aef891dc921c5fe34393a569();
  if(obj != null) {
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.JSONEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles, config);
  }
  return s;
}

public static Func<RC_28fdb7a8aef891dc921c5fe34393a569, ssConectaProveedores.RestRecords.JSONRC_28fdb7a8aef891dc921c5fe34393a569> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_28fdb7a8aef891dc921c5fe34393a569 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_28fdb7a8aef891dc921c5fe34393a569 FromStructure(RC_28fdb7a8aef891dc921c5fe34393a569 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_28fdb7a8aef891dc921c5fe34393a569(s, config);
}

}


