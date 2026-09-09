using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderMainOrderDetailRegionRecord
public class RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a : AbstractRESTStructure<RC_b944c231fcedefdc49a0fe2c36d0fb8a> {
[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("Region")]
public ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord AttrRegion;

public RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a() { }

public RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a (RC_b944c231fcedefdc49a0fe2c36d0fb8a s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrRegion = ConvertToRestWithoutDefaults(s.ssENRegion, new EN_31f501c551d210017fcb34b5237e3390EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure, config);
  } else {
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.FromStructure(s.ssENRegion, config);
  }
}

public static RC_b944c231fcedefdc49a0fe2c36d0fb8a ToStructure(ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a obj) { 
  RC_b944c231fcedefdc49a0fe2c36d0fb8a s = new RC_b944c231fcedefdc49a0fe2c36d0fb8a();
  if(obj != null) {
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  s.ssENRegion = ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord.ToStructure(obj.AttrRegion);
  }
  return s;
}

public static Func<RC_b944c231fcedefdc49a0fe2c36d0fb8a, ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_b944c231fcedefdc49a0fe2c36d0fb8a s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a FromStructure(RC_b944c231fcedefdc49a0fe2c36d0fb8a s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_b944c231fcedefdc49a0fe2c36d0fb8a(s, config);
}

}


