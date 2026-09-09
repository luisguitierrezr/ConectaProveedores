using OutSystems.RESTService.Runtime.Abstractions;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using System.Text.Json.Serialization;


namespace ssConectaProveedores.RestRecords;

// SeriesTypeRecord
public class JSONRC_8bfcc1d381d104953fbf01fd54a56e45 : AbstractRESTStructure<RC_8bfcc1d381d104953fbf01fd54a56e45> {
[JsonProperty("SeriesType")]
[JsonPropertyName("SeriesType")]
public ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord AttrSeriesType;

public JSONRC_8bfcc1d381d104953fbf01fd54a56e45() { }

public JSONRC_8bfcc1d381d104953fbf01fd54a56e45 (RC_8bfcc1d381d104953fbf01fd54a56e45 s, IBehaviorsConfiguration config) {
  if (config.DefaultValuesBehavior == DefaultValuesBehavior.DontSend) { 
AttrSeriesType = ConvertToRestWithoutDefaults(s.ssENSeriesType, new EN_12004a480323e1caa1d0e9cb95ddd993EntityRecord(), ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord.FromStructure, config);
  } else {
AttrSeriesType = ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord.FromStructure(s.ssENSeriesType, config);
  }
}

public static Func<ssConectaProveedores.RestRecords.JSONRC_8bfcc1d381d104953fbf01fd54a56e45, RC_8bfcc1d381d104953fbf01fd54a56e45> ToStructureDelegate(IBehaviorsConfiguration config) { 
  return (ssConectaProveedores.RestRecords.JSONRC_8bfcc1d381d104953fbf01fd54a56e45 s) => ToStructure(s, config);
}
public static RC_8bfcc1d381d104953fbf01fd54a56e45 ToStructure(ssConectaProveedores.RestRecords.JSONRC_8bfcc1d381d104953fbf01fd54a56e45 obj, IBehaviorsConfiguration config) { 
  RC_8bfcc1d381d104953fbf01fd54a56e45 s = new RC_8bfcc1d381d104953fbf01fd54a56e45();
  if(obj != null) {
  s.ssENSeriesType = ssConectaProveedores.RestRecords.JSONEN_12004a480323e1caa1d0e9cb95ddd993EntityRecord.ToStructure(obj.AttrSeriesType, config);
  }
  return s;
}

public static Func<RC_8bfcc1d381d104953fbf01fd54a56e45, ssConectaProveedores.RestRecords.JSONRC_8bfcc1d381d104953fbf01fd54a56e45> FromStructureDelegate(IBehaviorsConfiguration config) { 
  return (RC_8bfcc1d381d104953fbf01fd54a56e45 s) => FromStructure(s, config);
}
public static ssConectaProveedores.RestRecords.JSONRC_8bfcc1d381d104953fbf01fd54a56e45 FromStructure(RC_8bfcc1d381d104953fbf01fd54a56e45 s, IBehaviorsConfiguration config) { 
  return new ssConectaProveedores.RestRecords.JSONRC_8bfcc1d381d104953fbf01fd54a56e45(s, config);
}

}


