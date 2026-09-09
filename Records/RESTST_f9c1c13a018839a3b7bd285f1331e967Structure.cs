using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_CECO_COSMOZReq
public class RESTST_f9c1c13a018839a3b7bd285f1331e967Structure : AbstractRESTStructure<ST_f9c1c13a018839a3b7bd285f1331e967Structure> {
[JsonProperty("PI_HEADER")]
public ssConectaProveedores.RestRecords.RESTST_f6501ee18e176493154e18d361367656Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_4e772ab2be79435889bcf86fc0455824Structure> AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
public RestList<ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure> AttrPI_ITEM_SM;

public RESTST_f9c1c13a018839a3b7bd285f1331e967Structure() { }

public RESTST_f9c1c13a018839a3b7bd285f1331e967Structure (ST_f9c1c13a018839a3b7bd285f1331e967Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_f6501ee18e176493154e18d361367656Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToRestList<ssConectaProveedores.RestRecords.RESTST_4e772ab2be79435889bcf86fc0455824Structure>(ssConectaProveedores.RestRecords.RESTST_4e772ab2be79435889bcf86fc0455824Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToRestList<ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure>(ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.RESTST_f6501ee18e176493154e18d361367656Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToRestList<ssConectaProveedores.RestRecords.RESTST_4e772ab2be79435889bcf86fc0455824Structure>(ssConectaProveedores.RestRecords.RESTST_4e772ab2be79435889bcf86fc0455824Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToRestList<ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure>(ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure.FromStructureDelegate(config));
  }
}

public static ST_f9c1c13a018839a3b7bd285f1331e967Structure ToStructure(ssConectaProveedores.RestRecords.RESTST_f9c1c13a018839a3b7bd285f1331e967Structure obj) { 
  ST_f9c1c13a018839a3b7bd285f1331e967Structure s = new ST_f9c1c13a018839a3b7bd285f1331e967Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.RESTST_f6501ee18e176493154e18d361367656Structure.ToStructure(obj.AttrPI_HEADER);
  s.ssPI_ITEM_EM = RL_299977c13e39cc1952c431fa77f88689.FromRestList(obj.AttrPI_ITEM_EM, ssConectaProveedores.RestRecords.RESTST_4e772ab2be79435889bcf86fc0455824Structure.ToStructure);
  s.ssPI_ITEM_SM = RL_6c0520d55ae99ffd7c336b769881d282.FromRestList(obj.AttrPI_ITEM_SM, ssConectaProveedores.RestRecords.RESTST_e676179583470b305e615630acee7039Structure.ToStructure);
  }
  return s;
}

public static Func<ST_f9c1c13a018839a3b7bd285f1331e967Structure, ssConectaProveedores.RestRecords.RESTST_f9c1c13a018839a3b7bd285f1331e967Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f9c1c13a018839a3b7bd285f1331e967Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTST_f9c1c13a018839a3b7bd285f1331e967Structure FromStructure(ST_f9c1c13a018839a3b7bd285f1331e967Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTST_f9c1c13a018839a3b7bd285f1331e967Structure(s, config);
}

}


