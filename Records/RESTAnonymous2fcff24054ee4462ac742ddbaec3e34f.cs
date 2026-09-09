using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// OrderDetailRecord
public class RESTRC_7f0ffeffec7d0864eb8855fe8e873743 : AbstractRESTStructure<RC_7f0ffeffec7d0864eb8855fe8e873743> {
[JsonProperty("OrderDetail")]
public ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord AttrOrderDetail;

public RESTRC_7f0ffeffec7d0864eb8855fe8e873743() { }

public RESTRC_7f0ffeffec7d0864eb8855fe8e873743 (RC_7f0ffeffec7d0864eb8855fe8e873743 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrOrderDetail = ConvertToRestWithoutDefaults(s.ssENOrderDetail, new EN_26f696e758428762fc617e811634d15dEntityRecord(), ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure, config);
  } else {
AttrOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.FromStructure(s.ssENOrderDetail, config);
  }
}

public static RC_7f0ffeffec7d0864eb8855fe8e873743 ToStructure(ssConectaProveedores.RestRecords.RESTRC_7f0ffeffec7d0864eb8855fe8e873743 obj) { 
  RC_7f0ffeffec7d0864eb8855fe8e873743 s = new RC_7f0ffeffec7d0864eb8855fe8e873743();
  if(obj != null) {
  s.ssENOrderDetail = ssConectaProveedores.RestRecords.RESTEN_26f696e758428762fc617e811634d15dEntityRecord.ToStructure(obj.AttrOrderDetail);
  }
  return s;
}

public static Func<RC_7f0ffeffec7d0864eb8855fe8e873743, ssConectaProveedores.RestRecords.RESTRC_7f0ffeffec7d0864eb8855fe8e873743> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_7f0ffeffec7d0864eb8855fe8e873743 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_7f0ffeffec7d0864eb8855fe8e873743 FromStructure(RC_7f0ffeffec7d0864eb8855fe8e873743 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_7f0ffeffec7d0864eb8855fe8e873743(s, config);
}

}


