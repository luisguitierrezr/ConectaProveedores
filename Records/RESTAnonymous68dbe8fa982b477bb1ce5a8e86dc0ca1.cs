using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_GENERA_PEDIDO_PDFReqRecord
public class RESTRC_6499421cde34cd32d316edf8d06cbcc2 : AbstractRESTStructure<RC_6499421cde34cd32d316edf8d06cbcc2> {
[JsonProperty("ZMXMIMMF_GENERA_PEDIDO_PDFReq")]
public ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure AttrZMXMIMMF_GENERA_PEDIDO_PDFReq;

public RESTRC_6499421cde34cd32d316edf8d06cbcc2() { }

public RESTRC_6499421cde34cd32d316edf8d06cbcc2 (RC_6499421cde34cd32d316edf8d06cbcc2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_GENERA_PEDIDO_PDFReq = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq, new ST_7ddccdeb65a44283541a52358876da04Structure(), ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_GENERA_PEDIDO_PDFReq = ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure.FromStructure(s.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq, config);
  }
}

public static RC_6499421cde34cd32d316edf8d06cbcc2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_6499421cde34cd32d316edf8d06cbcc2 obj) { 
  RC_6499421cde34cd32d316edf8d06cbcc2 s = new RC_6499421cde34cd32d316edf8d06cbcc2();
  if(obj != null) {
  s.ssSTZMXMIMMF_GENERA_PEDIDO_PDFReq = ssConectaProveedores.RestRecords.RESTST_7ddccdeb65a44283541a52358876da04Structure.ToStructure(obj.AttrZMXMIMMF_GENERA_PEDIDO_PDFReq);
  }
  return s;
}

public static Func<RC_6499421cde34cd32d316edf8d06cbcc2, ssConectaProveedores.RestRecords.RESTRC_6499421cde34cd32d316edf8d06cbcc2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_6499421cde34cd32d316edf8d06cbcc2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_6499421cde34cd32d316edf8d06cbcc2 FromStructure(RC_6499421cde34cd32d316edf8d06cbcc2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_6499421cde34cd32d316edf8d06cbcc2(s, config);
}

}


