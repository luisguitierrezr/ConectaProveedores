using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXMIMMF_GENERA_PEDIDO_PDFRespRecord
public class JSONRC_bd6cd24c0d7565edb91c7512bb29c013 : AbstractRESTStructure<RC_bd6cd24c0d7565edb91c7512bb29c013> {
[JsonProperty("ZMXMIMMF_GENERA_PEDIDO_PDFResp")]
[JsonPropertyName("ZMXMIMMF_GENERA_PEDIDO_PDFResp")]
public ssConectaProveedores.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure AttrZMXMIMMF_GENERA_PEDIDO_PDFResp;

public JSONRC_bd6cd24c0d7565edb91c7512bb29c013() { }

public JSONRC_bd6cd24c0d7565edb91c7512bb29c013 (RC_bd6cd24c0d7565edb91c7512bb29c013 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXMIMMF_GENERA_PEDIDO_PDFResp = ConvertToRestWithoutDefaults(s.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp, new ST_bc70ab3695876bb4315a9088f41998b7Structure(), ssConectaProveedores.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure.FromStructure, config);
  } else {
AttrZMXMIMMF_GENERA_PEDIDO_PDFResp = ssConectaProveedores.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure.FromStructure(s.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_bd6cd24c0d7565edb91c7512bb29c013, RC_bd6cd24c0d7565edb91c7512bb29c013> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_bd6cd24c0d7565edb91c7512bb29c013 s) => ToStructure(s, config);
}
public static RC_bd6cd24c0d7565edb91c7512bb29c013 ToStructure(ssConectaProveedores.RestRecords.JSONRC_bd6cd24c0d7565edb91c7512bb29c013 obj, IBehaviorsConfiguration config) { 
  RC_bd6cd24c0d7565edb91c7512bb29c013 s = new RC_bd6cd24c0d7565edb91c7512bb29c013();
  if(obj != null) {
  s.ssSTZMXMIMMF_GENERA_PEDIDO_PDFResp = ssConectaProveedores.RestRecords.JSONST_bc70ab3695876bb4315a9088f41998b7Structure.ToStructure(obj.AttrZMXMIMMF_GENERA_PEDIDO_PDFResp, config);
  }
  return s;
}

public static Func<RC_bd6cd24c0d7565edb91c7512bb29c013, ssConectaProveedores.RestRecords.JSONRC_bd6cd24c0d7565edb91c7512bb29c013> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_bd6cd24c0d7565edb91c7512bb29c013 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_bd6cd24c0d7565edb91c7512bb29c013 FromStructure(RC_bd6cd24c0d7565edb91c7512bb29c013 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_bd6cd24c0d7565edb91c7512bb29c013(s, config);
}

}


