using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioSAPDataOrderMainItemFolioFolioItemsOrderMainRecord
public class RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8 : AbstractRESTStructure<RC_83164fc3d5a7c868e4cdd3a9acc28ad8> {
[JsonProperty("FolioSAPData")]
public ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord AttrFolioSAPData;

[JsonProperty("OrderMainItem")]
public ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord AttrOrderMainItem;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("FolioItems")]
public ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord AttrFolioItems;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8() { }

public RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8 (RC_83164fc3d5a7c868e4cdd3a9acc28ad8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioSAPData = ConvertToRestWithoutDefaults(s.ssENFolioSAPData, new EN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure, config);
AttrOrderMainItem = ConvertToRestWithoutDefaults(s.ssENOrderMainItem, new EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrFolioItems = ConvertToRestWithoutDefaults(s.ssENFolioItems, new EN_868430b5192a8eb1a739e01247fc2704EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrFolioSAPData = ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.FromStructure(s.ssENFolioSAPData, config);
AttrOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.FromStructure(s.ssENOrderMainItem, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.FromStructure(s.ssENFolioItems, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_83164fc3d5a7c868e4cdd3a9acc28ad8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8 obj) { 
  RC_83164fc3d5a7c868e4cdd3a9acc28ad8 s = new RC_83164fc3d5a7c868e4cdd3a9acc28ad8();
  if(obj != null) {
  s.ssENFolioSAPData = ssConectaProveedores.RestRecords.RESTEN_d1a20b731eb81bd7ec81c68b1d36e3fbEntityRecord.ToStructure(obj.AttrFolioSAPData);
  s.ssENOrderMainItem = ssConectaProveedores.RestRecords.RESTEN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord.ToStructure(obj.AttrOrderMainItem);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENFolioItems = ssConectaProveedores.RestRecords.RESTEN_868430b5192a8eb1a739e01247fc2704EntityRecord.ToStructure(obj.AttrFolioItems);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_83164fc3d5a7c868e4cdd3a9acc28ad8, ssConectaProveedores.RestRecords.RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_83164fc3d5a7c868e4cdd3a9acc28ad8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8 FromStructure(RC_83164fc3d5a7c868e4cdd3a9acc28ad8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_83164fc3d5a7c868e4cdd3a9acc28ad8(s, config);
}

}


