using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// InvoiceOrderMainRecord
public class RESTRC_7ea2828a21285060cce33ce8e91b5455 : AbstractRESTStructure<RC_7ea2828a21285060cce33ce8e91b5455> {
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord AttrInvoice;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

public RESTRC_7ea2828a21285060cce33ce8e91b5455() { }

public RESTRC_7ea2828a21285060cce33ce8e91b5455 (RC_7ea2828a21285060cce33ce8e91b5455 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrInvoice = ConvertToRestWithoutDefaults(s.ssENInvoice, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
  } else {
AttrInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.FromStructure(s.ssENInvoice, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
  }
}

public static RC_7ea2828a21285060cce33ce8e91b5455 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7ea2828a21285060cce33ce8e91b5455 obj) { 
  RC_7ea2828a21285060cce33ce8e91b5455 s = new RC_7ea2828a21285060cce33ce8e91b5455();
  if(obj != null) {
  s.ssENInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(obj.AttrInvoice);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  }
  return s;
}

public static Func<RC_7ea2828a21285060cce33ce8e91b5455, ssConectaProveedores.RestRecords.RESTRC_7ea2828a21285060cce33ce8e91b5455> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7ea2828a21285060cce33ce8e91b5455 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7ea2828a21285060cce33ce8e91b5455 FromStructure(RC_7ea2828a21285060cce33ce8e91b5455 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7ea2828a21285060cce33ce8e91b5455(s, config);
}

}


