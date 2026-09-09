using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_EM_SM_CECO_COSMOZReq
public class JSONST_f9c1c13a018839a3b7bd285f1331e967Structure : AbstractRESTStructure<ST_f9c1c13a018839a3b7bd285f1331e967Structure> {
[JsonProperty("PI_HEADER")]
[JsonPropertyName("PI_HEADER")]
public ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure AttrPI_HEADER;

[JsonProperty("PI_ITEM_EM")]
[JsonPropertyName("PI_ITEM_EM")]
public ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure[] AttrPI_ITEM_EM;

[JsonProperty("PI_ITEM_SM")]
[JsonPropertyName("PI_ITEM_SM")]
public ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure[] AttrPI_ITEM_SM;

public JSONST_f9c1c13a018839a3b7bd285f1331e967Structure() { }

public JSONST_f9c1c13a018839a3b7bd285f1331e967Structure (ST_f9c1c13a018839a3b7bd285f1331e967Structure s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToArray<ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure>(ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToArray<ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure>(ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure.FromStructureDelegate(config));
  } else {
AttrPI_HEADER = ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure.FromStructure(s.ssPI_HEADER, config);
AttrPI_ITEM_EM = s.ssPI_ITEM_EM.ToArray<ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure>(ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure.FromStructureDelegate(config));
AttrPI_ITEM_SM = s.ssPI_ITEM_SM.ToArray<ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure>(ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure.FromStructureDelegate(config));
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure, ST_f9c1c13a018839a3b7bd285f1331e967Structure> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure s) => ToStructure(s, config);
}
public static ST_f9c1c13a018839a3b7bd285f1331e967Structure ToStructure(ssConectaProveedores.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure obj, IBehaviorsConfiguration config) { 
  ST_f9c1c13a018839a3b7bd285f1331e967Structure s = new ST_f9c1c13a018839a3b7bd285f1331e967Structure();
  if(obj != null) {
  s.ssPI_HEADER = ssConectaProveedores.RestRecords.JSONST_f6501ee18e176493154e18d361367656Structure.ToStructure(obj.AttrPI_HEADER, config);
  s.ssPI_ITEM_EM = RL_299977c13e39cc1952c431fa77f88689.ToList(obj.AttrPI_ITEM_EM, ssConectaProveedores.RestRecords.JSONST_4e772ab2be79435889bcf86fc0455824Structure.ToStructureDelegate(config));
  s.ssPI_ITEM_SM = RL_6c0520d55ae99ffd7c336b769881d282.ToList(obj.AttrPI_ITEM_SM, ssConectaProveedores.RestRecords.JSONST_e676179583470b305e615630acee7039Structure.ToStructureDelegate(config));
  }
  return s;
}

public static Func<ST_f9c1c13a018839a3b7bd285f1331e967Structure, ssConectaProveedores.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (ST_f9c1c13a018839a3b7bd285f1331e967Structure s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure FromStructure(ST_f9c1c13a018839a3b7bd285f1331e967Structure s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONST_f9c1c13a018839a3b7bd285f1331e967Structure(s, config);
}

}


