using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_CONTA_FACTURASReqRecord
public class JSONRC_506e7681e4494051bd2c8f2d45737647 : AbstractRESTStructure<RC_506e7681e4494051bd2c8f2d45737647> {
[JsonProperty("ZMXFFIMF_CONTA_FACTURASReq")]
[JsonPropertyName("ZMXFFIMF_CONTA_FACTURASReq")]
public ssConectaProveedores.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure AttrZMXFFIMF_CONTA_FACTURASReq;

public JSONRC_506e7681e4494051bd2c8f2d45737647() { }

public JSONRC_506e7681e4494051bd2c8f2d45737647 (RC_506e7681e4494051bd2c8f2d45737647 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_CONTA_FACTURASReq = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_CONTA_FACTURASReq, new ST_012aef00497ef6b298e25799608b1289Structure(), ssConectaProveedores.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_CONTA_FACTURASReq = ssConectaProveedores.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure.FromStructure(s.ssSTZMXFFIMF_CONTA_FACTURASReq, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_506e7681e4494051bd2c8f2d45737647, RC_506e7681e4494051bd2c8f2d45737647> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_506e7681e4494051bd2c8f2d45737647 s) => ToStructure(s, config);
}
public static RC_506e7681e4494051bd2c8f2d45737647 ToStructure(ssConectaProveedores.RestRecords.JSONRC_506e7681e4494051bd2c8f2d45737647 obj, IBehaviorsConfiguration config) { 
  RC_506e7681e4494051bd2c8f2d45737647 s = new RC_506e7681e4494051bd2c8f2d45737647();
  if(obj != null) {
  s.ssSTZMXFFIMF_CONTA_FACTURASReq = ssConectaProveedores.RestRecords.JSONST_012aef00497ef6b298e25799608b1289Structure.ToStructure(obj.AttrZMXFFIMF_CONTA_FACTURASReq, config);
  }
  return s;
}

public static Func<RC_506e7681e4494051bd2c8f2d45737647, ssConectaProveedores.RestRecords.JSONRC_506e7681e4494051bd2c8f2d45737647> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_506e7681e4494051bd2c8f2d45737647 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_506e7681e4494051bd2c8f2d45737647 FromStructure(RC_506e7681e4494051bd2c8f2d45737647 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_506e7681e4494051bd2c8f2d45737647(s, config);
}

}


