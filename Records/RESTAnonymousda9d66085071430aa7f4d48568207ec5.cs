using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PaymentWaysRecord
public class RESTRC_4a8ab393337b882018e44511f7ddbaa8 : AbstractRESTStructure<RC_4a8ab393337b882018e44511f7ddbaa8> {
[JsonProperty("PaymentWays")]
public ssConectaProveedores.RestRecords.RESTEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord AttrPaymentWays;

public RESTRC_4a8ab393337b882018e44511f7ddbaa8() { }

public RESTRC_4a8ab393337b882018e44511f7ddbaa8 (RC_4a8ab393337b882018e44511f7ddbaa8 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPaymentWays = ConvertToRestWithoutDefaults(s.ssENPaymentWays, new EN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord.FromStructure, config);
  } else {
AttrPaymentWays = ssConectaProveedores.RestRecords.RESTEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord.FromStructure(s.ssENPaymentWays, config);
  }
}

public static RC_4a8ab393337b882018e44511f7ddbaa8 ToStructure(ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8 obj) { 
  RC_4a8ab393337b882018e44511f7ddbaa8 s = new RC_4a8ab393337b882018e44511f7ddbaa8();
  if(obj != null) {
  s.ssENPaymentWays = ssConectaProveedores.RestRecords.RESTEN_16f07ea11d30dfe052ad03e4a9bcc7b8EntityRecord.ToStructure(obj.AttrPaymentWays);
  }
  return s;
}

public static Func<RC_4a8ab393337b882018e44511f7ddbaa8, ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_4a8ab393337b882018e44511f7ddbaa8 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8 FromStructure(RC_4a8ab393337b882018e44511f7ddbaa8 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8(s, config);
}

}


