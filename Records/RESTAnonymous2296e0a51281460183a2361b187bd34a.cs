using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioApprovalFolioOrderMainRecord
public class RESTRC_f7c91773292f225022263e13d34e21c5 : AbstractRESTStructure<RC_f7c91773292f225022263e13d34e21c5> {
[JsonProperty("FolioApproval")]
public ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord AttrFolioApproval;

[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_f7c91773292f225022263e13d34e21c5() { }

public RESTRC_f7c91773292f225022263e13d34e21c5 (RC_f7c91773292f225022263e13d34e21c5 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolioApproval = ConvertToRestWithoutDefaults(s.ssENFolioApproval, new EN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure, config);
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.FromStructure(s.ssENFolioApproval, config);
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_f7c91773292f225022263e13d34e21c5 ToStructure(ssConectaProveedores.RestRecords.RESTRC_f7c91773292f225022263e13d34e21c5 obj) { 
  RC_f7c91773292f225022263e13d34e21c5 s = new RC_f7c91773292f225022263e13d34e21c5();
  if(obj != null) {
  s.ssENFolioApproval = ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord.ToStructure(obj.AttrFolioApproval);
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_f7c91773292f225022263e13d34e21c5, ssConectaProveedores.RestRecords.RESTRC_f7c91773292f225022263e13d34e21c5> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_f7c91773292f225022263e13d34e21c5 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_f7c91773292f225022263e13d34e21c5 FromStructure(RC_f7c91773292f225022263e13d34e21c5 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_f7c91773292f225022263e13d34e21c5(s, config);
}

}


