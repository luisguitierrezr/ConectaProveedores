using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderStatusOrderApprovalOrderMainOrderDetailOrderApprovalLevelSupplierUserSupplierRecord
public class RESTRC_06eea14cc287e1e6b6d33a1bc97971e2 : AbstractRESTStructure<RC_06eea14cc287e1e6b6d33a1bc97971e2> {
[JsonProperty("OrderStatus")]
public ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord AttrOrderStatus;

[JsonProperty("OrderApproval")]
public ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord AttrOrderApproval;

[JsonProperty("OrderMain")]
public ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord AttrOrderMain;

[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

[JsonProperty("OrderApprovalLevel")]
public ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord AttrOrderApprovalLevel;

[JsonProperty("SupplierUser")]
public ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord AttrSupplierUser;

[JsonProperty("Supplier")]
public ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord AttrSupplier;

public RESTRC_06eea14cc287e1e6b6d33a1bc97971e2() { }

public RESTRC_06eea14cc287e1e6b6d33a1bc97971e2 (RC_06eea14cc287e1e6b6d33a1bc97971e2 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderStatus = ConvertToRestWithoutDefaults(s.ssENOrderStatus, new EN_5eda60810da752f579e01795bb7e0de0EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure, config);
AttrOrderApproval = ConvertToRestWithoutDefaults(s.ssENOrderApproval, new EN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure, config);
AttrOrderMain = ConvertToRestWithoutDefaults(s.ssENOrderMain, new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure, config);
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
AttrOrderApprovalLevel = ConvertToRestWithoutDefaults(s.ssENOrderApprovalLevel, new EN_6b660d05e4c0025dff47119642875ca2EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure, config);
AttrSupplierUser = ConvertToRestWithoutDefaults(s.ssENSupplierUser, new EN_360367a38fba8439556dd1e5826e0428EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure, config);
AttrSupplier = ConvertToRestWithoutDefaults(s.ssENSupplier, new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord(), ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure, config);
  } else {
AttrOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.FromStructure(s.ssENOrderStatus, config);
AttrOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.FromStructure(s.ssENOrderApproval, config);
AttrOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.FromStructure(s.ssENOrderMain, config);
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
AttrOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.FromStructure(s.ssENOrderApprovalLevel, config);
AttrSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.FromStructure(s.ssENSupplierUser, config);
AttrSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.FromStructure(s.ssENSupplier, config);
  }
}

public static RC_06eea14cc287e1e6b6d33a1bc97971e2 ToStructure(ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2 obj) { 
  RC_06eea14cc287e1e6b6d33a1bc97971e2 s = new RC_06eea14cc287e1e6b6d33a1bc97971e2();
  if(obj != null) {
  s.ssENOrderStatus = ssConectaProveedores.RestRecords.RESTEN_5eda60810da752f579e01795bb7e0de0EntityRecord.ToStructure(obj.AttrOrderStatus);
  s.ssENOrderApproval = ssConectaProveedores.RestRecords.RESTEN_7c258d31ea1bd784722cc1483f1cb26bEntityRecord.ToStructure(obj.AttrOrderApproval);
  s.ssENOrderMain = ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord.ToStructure(obj.AttrOrderMain);
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  s.ssENOrderApprovalLevel = ssConectaProveedores.RestRecords.RESTEN_6b660d05e4c0025dff47119642875ca2EntityRecord.ToStructure(obj.AttrOrderApprovalLevel);
  s.ssENSupplierUser = ssConectaProveedores.RestRecords.RESTEN_360367a38fba8439556dd1e5826e0428EntityRecord.ToStructure(obj.AttrSupplierUser);
  s.ssENSupplier = ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord.ToStructure(obj.AttrSupplier);
  }
  return s;
}

public static Func<RC_06eea14cc287e1e6b6d33a1bc97971e2, ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_06eea14cc287e1e6b6d33a1bc97971e2 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2 FromStructure(RC_06eea14cc287e1e6b6d33a1bc97971e2 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_06eea14cc287e1e6b6d33a1bc97971e2(s, config);
}

}


