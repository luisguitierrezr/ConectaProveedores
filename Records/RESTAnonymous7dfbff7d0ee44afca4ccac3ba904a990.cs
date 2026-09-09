using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// ZMXFFIMF_CONTA_FACTURASReqRecord
public class RESTRC_506e7681e4494051bd2c8f2d45737647 : AbstractRESTStructure<RC_506e7681e4494051bd2c8f2d45737647> {
[JsonProperty("ZMXFFIMF_CONTA_FACTURASReq")]
public ssConectaProveedores.RestRecords.RESTST_012aef00497ef6b298e25799608b1289Structure AttrZMXFFIMF_CONTA_FACTURASReq;

public RESTRC_506e7681e4494051bd2c8f2d45737647() { }

public RESTRC_506e7681e4494051bd2c8f2d45737647 (RC_506e7681e4494051bd2c8f2d45737647 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrZMXFFIMF_CONTA_FACTURASReq = ConvertToRestWithoutDefaults(s.ssSTZMXFFIMF_CONTA_FACTURASReq, new ST_012aef00497ef6b298e25799608b1289Structure(), ssConectaProveedores.RestRecords.RESTST_012aef00497ef6b298e25799608b1289Structure.FromStructure, config);
  } else {
AttrZMXFFIMF_CONTA_FACTURASReq = ssConectaProveedores.RestRecords.RESTST_012aef00497ef6b298e25799608b1289Structure.FromStructure(s.ssSTZMXFFIMF_CONTA_FACTURASReq, config);
  }
}

public static RC_506e7681e4494051bd2c8f2d45737647 ToStructure(ssConectaProveedores.RestRecords.RESTRC_506e7681e4494051bd2c8f2d45737647 obj) { 
  RC_506e7681e4494051bd2c8f2d45737647 s = new RC_506e7681e4494051bd2c8f2d45737647();
  if(obj != null) {
  s.ssSTZMXFFIMF_CONTA_FACTURASReq = ssConectaProveedores.RestRecords.RESTST_012aef00497ef6b298e25799608b1289Structure.ToStructure(obj.AttrZMXFFIMF_CONTA_FACTURASReq);
  }
  return s;
}

public static Func<RC_506e7681e4494051bd2c8f2d45737647, ssConectaProveedores.RestRecords.RESTRC_506e7681e4494051bd2c8f2d45737647> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_506e7681e4494051bd2c8f2d45737647 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_506e7681e4494051bd2c8f2d45737647 FromStructure(RC_506e7681e4494051bd2c8f2d45737647 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_506e7681e4494051bd2c8f2d45737647(s, config);
}

}


