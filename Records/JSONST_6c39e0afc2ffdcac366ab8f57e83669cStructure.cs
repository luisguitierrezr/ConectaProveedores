using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_COSMOZReq
public class JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure : AbstractRESTStructure<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM")]
[JsonPropertyName("PI_ITEM")]
public ssConectaProveedores.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure[] AttrPI_ITEM;

public JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure() { }

public JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM = s.ssPI_ITEM.ToArray<ssConectaProveedores.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure>(ssConectaProveedores.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM = s.ssPI_ITEM.ToArray<ssConectaProveedores.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure>(ssConectaProveedores.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure, ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure s) => ToStructure(s, config);
}
public static ST_6c39e0afc2ffdcac366ab8f57e83669cStructure ToStructure(ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure obj, IBehaviorsConfiguration config) { 
  ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s = new ST_6c39e0afc2ffdcac366ab8f57e83669cStructure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.JSONST_af46d22a4ab690d6a003acf927bb2771Structure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM = RL_5f4f6d8d3b3fb597b315a01bc1951a9b.ToList(obj.AttrPI_ITEM, ssConectaProveedores.RestRecords.JSONST_d34c4878f870709fdbf7a3e48e70a4edStructure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure, ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure FromStructure(ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_6c39e0afc2ffdcac366ab8f57e83669cStructure(s, config);
}

}


