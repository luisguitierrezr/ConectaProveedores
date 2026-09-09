using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// FolioOrderMainRecord
public class RESTRC_d80dcf5f9effb79b8ba59dd1971d484d : AbstractRESTStructure<RC_d80dcf5f9effb79b8ba59dd1971d484d> {
[JsonProperty("Folio")]
public ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord AttrFolio;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_d80dcf5f9effb79b8ba59dd1971d484d() { }

public RESTRC_d80dcf5f9effb79b8ba59dd1971d484d (RC_d80dcf5f9effb79b8ba59dd1971d484d s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrFolio = ConvertToRestWithoutDefaults(s.ssENFolio, new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.FromStructure(s.ssENFolio, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_d80dcf5f9effb79b8ba59dd1971d484d ToStructure(ssConectaProveedores.RestRecords.RESTRC_d80dcf5f9effb79b8ba59dd1971d484d obj) { 
  RC_d80dcf5f9effb79b8ba59dd1971d484d s = new RC_d80dcf5f9effb79b8ba59dd1971d484d();
  if(obj != null) {
  s.ssENFolio = ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord.ToStructure(obj.AttrFolio);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_d80dcf5f9effb79b8ba59dd1971d484d, ssConectaProveedores.RestRecords.RESTRC_d80dcf5f9effb79b8ba59dd1971d484d> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_d80dcf5f9effb79b8ba59dd1971d484d s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_d80dcf5f9effb79b8ba59dd1971d484d FromStructure(RC_d80dcf5f9effb79b8ba59dd1971d484d s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_d80dcf5f9effb79b8ba59dd1971d484d(s, config);
}

}


