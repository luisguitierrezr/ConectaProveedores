using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// PI_HEADER4Record
public class RESTRC_cb1635938264c06d8723ef02327570a7 : AbstractRESTStructure<RC_cb1635938264c06d8723ef02327570a7> {
[JsonProperty("PI_HEADER4")]
public ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure AttrPI_HEADER4;

public RESTRC_cb1635938264c06d8723ef02327570a7() { }

public RESTRC_cb1635938264c06d8723ef02327570a7 (RC_cb1635938264c06d8723ef02327570a7 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrPI_HEADER4 = ConvertToRestWithoutDefaults(s.ssSTPI_HEADER4, new ST_b8bada9441ba6abcbadb418a924fe551Structure(), ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure.FromStructure, config);
  } else {
AttrPI_HEADER4 = ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure.FromStructure(s.ssSTPI_HEADER4, config);
  }
}

public static RC_cb1635938264c06d8723ef02327570a7 ToStructure(ssConectaProveedores.RestRecords.RESTRC_cb1635938264c06d8723ef02327570a7 obj) { 
  RC_cb1635938264c06d8723ef02327570a7 s = new RC_cb1635938264c06d8723ef02327570a7();
  if(obj != null) {
  s.ssSTPI_HEADER4 = ssConectaProveedores.RestRecords.RESTST_b8bada9441ba6abcbadb418a924fe551Structure.ToStructure(obj.AttrPI_HEADER4);
  }
  return s;
}

public static Func<RC_cb1635938264c06d8723ef02327570a7, ssConectaProveedores.RestRecords.RESTRC_cb1635938264c06d8723ef02327570a7> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_cb1635938264c06d8723ef02327570a7 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.RESTRC_cb1635938264c06d8723ef02327570a7 FromStructure(RC_cb1635938264c06d8723ef02327570a7 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.RESTRC_cb1635938264c06d8723ef02327570a7(s, config);
}

}


