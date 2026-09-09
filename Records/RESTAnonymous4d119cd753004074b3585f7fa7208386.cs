using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioFilesRecord
public class RESTRC_28fdb7a8aef891dc921c5fe34393a569 : AbstractRESTStructure<RC_28fdb7a8aef891dc921c5fe34393a569> {
[JsonProperty("FolioFiles")]
public ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord AttrFolioFiles;

public RESTRC_28fdb7a8aef891dc921c5fe34393a569() { }

public RESTRC_28fdb7a8aef891dc921c5fe34393a569 (RC_28fdb7a8aef891dc921c5fe34393a569 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioFiles = ConvertToRestWithoutDefaults(s.ssENFolioFiles, new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure, config);
  } else {
AttrFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.FromStructure(s.ssENFolioFiles, config);
  }
}

public static RC_28fdb7a8aef891dc921c5fe34393a569 ToStructure(ssConectaProveedores.RestRecords.RESTRC_28fdb7a8aef891dc921c5fe34393a569 obj) { 
  RC_28fdb7a8aef891dc921c5fe34393a569 s = new RC_28fdb7a8aef891dc921c5fe34393a569();
  if(obj != null) {
  s.ssENFolioFiles = ssConectaProveedores.RestRecords.RESTEN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord.ToStructure(obj.AttrFolioFiles);
  }
  return s;
}

public static Func<RC_28fdb7a8aef891dc921c5fe34393a569, ssConectaProveedores.RestRecords.RESTRC_28fdb7a8aef891dc921c5fe34393a569> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_28fdb7a8aef891dc921c5fe34393a569 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_28fdb7a8aef891dc921c5fe34393a569 FromStructure(RC_28fdb7a8aef891dc921c5fe34393a569 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_28fdb7a8aef891dc921c5fe34393a569(s, config);
}

}


