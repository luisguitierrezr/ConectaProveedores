using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_CONTA_FACTURASResp
public class RESTST_926df962559a6c34055113c885aa4885Structure : AbstractRESTStructure<ST_926df962559a6c34055113c885aa4885Structure> {
[JsonProperty("PE_RESPUESTA")]
public string AttrPE_RESPUESTA;

[JsonProperty("TI_ITEM_Out")]
public RestList<ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure> AttrTI_ITEM_Out;

[JsonProperty("TI_WXD_Out")]
public RestList<ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure> AttrTI_WXD_Out;

public RESTST_926df962559a6c34055113c885aa4885Structure() { }

public RESTST_926df962559a6c34055113c885aa4885Structure (ST_926df962559a6c34055113c885aa4885Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPE_RESPUESTA = ConvertToRestWithoutDefaults(s.ssPE_RESPUESTA, "");
AttrTI_ITEM_Out = s.ssTI_ITEM_Out.Length == 0 ? null : s.ssTI_ITEM_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure>(ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure.FromStructureDelegate(config));
AttrTI_WXD_Out = s.ssTI_WXD_Out.Length == 0 ? null : s.ssTI_WXD_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure>(ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure.FromStructureDelegate(config));
  } else {
AttrPE_RESPUESTA = s.ssPE_RESPUESTA;
AttrTI_ITEM_Out = s.ssTI_ITEM_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure>(ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure.FromStructureDelegate(config));
AttrTI_WXD_Out = s.ssTI_WXD_Out.ToRestList<ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure>(ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure.FromStructureDelegate(config));
  }
}

public static ST_926df962559a6c34055113c885aa4885Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_926df962559a6c34055113c885aa4885Structure obj) { 
  ST_926df962559a6c34055113c885aa4885Structure s = new ST_926df962559a6c34055113c885aa4885Structure();
  if(obj != null) {
  s.ssPE_RESPUESTA = obj.AttrPE_RESPUESTA == null ? "" : obj.AttrPE_RESPUESTA;
  s.ssTI_ITEM_Out = RL_e1d78e9541666a9f848546c9e0e8c78e.FromRestList(obj.AttrTI_ITEM_Out, ssConectaProveedores.RestRecords.RESTST_3b61de88b81d785d0616b445a04890fdStructure.ToStructure);
  s.ssTI_WXD_Out = RL_ede476728417dba9bcd8aba956158c2a.FromRestList(obj.AttrTI_WXD_Out, ssConectaProveedores.RestRecords.RESTST_646bfb521d5f3e3e304163b436da5220Structure.ToStructure);
  }
  return s;
}

public static Func<ST_926df962559a6c34055113c885aa4885Structure, ssConectaProveedores.RestRecords.RESTST_926df962559a6c34055113c885aa4885Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_926df962559a6c34055113c885aa4885Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_926df962559a6c34055113c885aa4885Structure FromStructure(ST_926df962559a6c34055113c885aa4885Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_926df962559a6c34055113c885aa4885Structure(s, config);
}

}


