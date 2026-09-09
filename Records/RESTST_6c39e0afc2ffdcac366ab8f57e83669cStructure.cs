using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_COSMOZReq
public class RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure : AbstractRESTStructure<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure> AttrPI_ITEM;

public RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure() { }

public RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM = s.ssPI_ITEM.ToRestList<ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure>(ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM = s.ssPI_ITEM.ToRestList<ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure>(ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure.FromStructureDelegate(config));
  }
}

public static ST_6c39e0afc2ffdcac366ab8f57e83669cStructure ToStructure(ssConectaProveedores.RestRecords.RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure obj) { 
  ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s = new ST_6c39e0afc2ffdcac366ab8f57e83669cStructure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_af46d22a4ab690d6a003acf927bb2771Structure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM = RL_5f4f6d8d3b3fb597b315a01bc1951a9b.FromRestList(obj.AttrPI_ITEM, ssConectaProveedores.RestRecords.RESTST_d34c4878f870709fdbf7a3e48e70a4edStructure.ToStructure);
  }
  return s;
}

public static Func<ST_6c39e0afc2ffdcac366ab8f57e83669cStructure, ssConectaProveedores.RestRecords.RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure FromStructure(ST_6c39e0afc2ffdcac366ab8f57e83669cStructure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_6c39e0afc2ffdcac366ab8f57e83669cStructure(s, config);
}

}


