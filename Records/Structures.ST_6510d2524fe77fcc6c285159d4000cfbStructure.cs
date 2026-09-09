namespace ssConectaProveedores {
/// <summary>
/// [ReferenceStructure] VideoOptionalConfigs (lBNDZoiwJU6ZIySZy0DgJA)
///  <code>ST_6510d2524fe77fcc6c285159d4000cfbStructure</code> that represent
/// s <code>VideoOptionalConfigs</code> <p>Description: Video optional internal configurations</p>
/// </summary>
// Name: VideoOptionalConfigs
public partial struct ST_6510d2524fe77fcc6c285159d4000cfbStructure : ITypedRecord<ST_6510d2524fe77fcc6c285159d4000cfbStructure> {
internal static readonly GlobalObjectKey IdAutoplay = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*P+W3PwwGUkabFSnyjpoTRg");
internal static readonly GlobalObjectKey IdLoop = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*N904MXjCq0qaG0oqPkX43g");
internal static readonly GlobalObjectKey IdMuted = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*q6aNHbXVIUCysh05zDtllg");
internal static readonly GlobalObjectKey IdPosterURL = GlobalObjectKey.Parse("Kn_hixxDWEm4lMd7mIpycQ*MitRizoZCUeHxAfkK9o9UA");

public bool ssAutoplay;

public bool ssLoop;

public bool ssMuted;

public string ssPosterURL;


public BitArray OptimizedAttributes;

public ST_6510d2524fe77fcc6c285159d4000cfbStructure() {
OptimizedAttributes = null;
ssAutoplay = false;
ssLoop = false;
ssMuted = false;
ssPosterURL = "";
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssAutoplay = r.ReadBoolean(index++, "VideoOptionalConfigs.Autoplay", false);
ssLoop = r.ReadBoolean(index++, "VideoOptionalConfigs.Loop", false);
ssMuted = r.ReadBoolean(index++, "VideoOptionalConfigs.Muted", false);
ssPosterURL = r.ReadText(index++, "VideoOptionalConfigs.PosterURL", "");
}
/// <summary>
/// Read from database
/// </summary>
/// <param name="r"> Data reader</param>
public void ReadDB( DbDataReader r) {
int index = 0;
Read(r, ref index);
}

/// <summary>
/// Read from record
/// </summary>
/// <param name="r"> Record</param>
public void ReadIM(ST_6510d2524fe77fcc6c285159d4000cfbStructure r) {
this = r;
}


public static bool operator == (ST_6510d2524fe77fcc6c285159d4000cfbStructure a, ST_6510d2524fe77fcc6c285159d4000cfbStructure b) {
if (a.ssAutoplay != b.ssAutoplay) return false;
if (a.ssLoop != b.ssLoop) return false;
if (a.ssMuted != b.ssMuted) return false;
if (a.ssPosterURL != b.ssPosterURL) return false;
return true;
}

public static bool operator != (ST_6510d2524fe77fcc6c285159d4000cfbStructure a, ST_6510d2524fe77fcc6c285159d4000cfbStructure b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (ST_6510d2524fe77fcc6c285159d4000cfbStructure)) return false;
return (this == (ST_6510d2524fe77fcc6c285159d4000cfbStructure)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssAutoplay.GetHashCode()
 ^ ssLoop.GetHashCode()
 ^ ssMuted.GetHashCode()
 ^ ssPosterURL.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public ST_6510d2524fe77fcc6c285159d4000cfbStructure Duplicate() {
ST_6510d2524fe77fcc6c285159d4000cfbStructure t;
t.ssAutoplay = this.ssAutoplay;
t.ssLoop = this.ssLoop;
t.ssMuted = this.ssMuted;
t.ssPosterURL = this.ssPosterURL;
t.OptimizedAttributes = null;
return t;
}

IRecord IRecord.Duplicate() {
return Duplicate();
}

public void ToXml(Object parent, System.Xml.XmlElement baseElem, String fieldName, int detailLevel) {
throw new System.InvalidOperationException();
}

public void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
String head = VarValue.GetHead(fields);
String tail = VarValue.GetTail(fields);
variable.Found = false;
if (head == "autoplay") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Autoplay")) variable.Value = ssAutoplay; else variable.Optimized = true;
} else if (head == "loop") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Loop")) variable.Value = ssLoop; else variable.Optimized = true;
} else if (head == "muted") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Muted")) variable.Value = ssMuted; else variable.Optimized = true;
} else if (head == "posterurl") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PosterURL")) variable.Value = ssPosterURL; else variable.Optimized = true;
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
throw new System.InvalidOperationException();
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdAutoplay) {
return ssAutoplay;
}
if (key == IdLoop) {
return ssLoop;
}
if (key == IdMuted) {
return ssMuted;
}
if (key == IdPosterURL) {
return ssPosterURL;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAutoplay.Key.AsGuid) {
return ssAutoplay;
}
if (attributeKey == IdLoop.Key.AsGuid) {
return ssLoop;
}
if (attributeKey == IdMuted.Key.AsGuid) {
return ssMuted;
}
if (attributeKey == IdPosterURL.Key.AsGuid) {
return ssPosterURL;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssAutoplay = (bool) other.AttributeGet(IdAutoplay);
ssLoop = (bool) other.AttributeGet(IdLoop);
ssMuted = (bool) other.AttributeGet(IdMuted);
ssPosterURL = (string) other.AttributeGet(IdPosterURL);
}
} // ST_6510d2524fe77fcc6c285159d4000cfbStructure
/// <summary>
/// RecordList type <code>VideoOptionalConfigsList</code> that represents a record list of
///  <code>VideoOptionalConfigs</code>
/// </summary>
public partial class RL_95d0d522cef60364076f377317e08b52 : GenericRecordList<ST_6510d2524fe77fcc6c285159d4000cfbStructure>, IEnumerable, IEnumerator {

protected override ST_6510d2524fe77fcc6c285159d4000cfbStructure GetElementDefaultValue() {
return new ST_6510d2524fe77fcc6c285159d4000cfbStructure();
}

public T[] ToArray<T>(Func<ST_6510d2524fe77fcc6c285159d4000cfbStructure, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_95d0d522cef60364076f377317e08b52 recordList, Func<ST_6510d2524fe77fcc6c285159d4000cfbStructure, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_95d0d522cef60364076f377317e08b52(ST_6510d2524fe77fcc6c285159d4000cfbStructure[] array) {
  RL_95d0d522cef60364076f377317e08b52 result = new RL_95d0d522cef60364076f377317e08b52();
result.InnerFromArray(array);
    return result;
}

public static RL_95d0d522cef60364076f377317e08b52 ToList<T>(T[] array, Func <T, ST_6510d2524fe77fcc6c285159d4000cfbStructure> converter) {
  RL_95d0d522cef60364076f377317e08b52 result = new RL_95d0d522cef60364076f377317e08b52();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_95d0d522cef60364076f377317e08b52 FromRestList<T>(RestList<T> restList, Func <T, ST_6510d2524fe77fcc6c285159d4000cfbStructure> converter) {
  RL_95d0d522cef60364076f377317e08b52 result = new RL_95d0d522cef60364076f377317e08b52();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_95d0d522cef60364076f377317e08b52() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<ST_6510d2524fe77fcc6c285159d4000cfbStructure> NewList() {
return new RL_95d0d522cef60364076f377317e08b52();
}


} // RL_95d0d522cef60364076f377317e08b52
}

