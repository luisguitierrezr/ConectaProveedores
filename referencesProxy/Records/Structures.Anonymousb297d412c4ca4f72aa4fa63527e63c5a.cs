namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (EtSXssrEck+qT6Y1J+Y8Wg)
///  <code>RC_deb85dc36640fa928dae5df2493065d0</code> that represents <code>RegionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: RegionRecord
public partial struct RC_deb85dc36640fa928dae5df2493065d0 : ITypedRecord<RC_deb85dc36640fa928dae5df2493065d0> {
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public static implicit operator EN_31f501c551d210017fcb34b5237e3390EntityRecord( RC_deb85dc36640fa928dae5df2493065d0 r) {
return r.ssENRegion;
}

public static implicit operator RC_deb85dc36640fa928dae5df2493065d0 (EN_31f501c551d210017fcb34b5237e3390EntityRecord r) {
RC_deb85dc36640fa928dae5df2493065d0 res = new RC_deb85dc36640fa928dae5df2493065d0 ();
res.ssENRegion = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRegion.ChangedAttributes = value;
}
get {
    return ssENRegion.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_deb85dc36640fa928dae5df2493065d0() {
OptimizedAttributes = null;
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRegion.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRegion.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_deb85dc36640fa928dae5df2493065d0 r) {
this = r;
}


public static bool operator == (RC_deb85dc36640fa928dae5df2493065d0 a, RC_deb85dc36640fa928dae5df2493065d0 b) {
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_deb85dc36640fa928dae5df2493065d0 a, RC_deb85dc36640fa928dae5df2493065d0 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_deb85dc36640fa928dae5df2493065d0)) return false;
return (this == (RC_deb85dc36640fa928dae5df2493065d0)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRegion.InternalRecursiveSave();
}


public RC_deb85dc36640fa928dae5df2493065d0 Duplicate() {
RC_deb85dc36640fa928dae5df2493065d0 t;
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRegion.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRegion.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRegion) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_deb85dc36640fa928dae5df2493065d0
/// <summary>
/// RecordList type <code>RegionRecordList</code> that represents a record list of <code>Region</code>
/// </summary>
public partial class RL_5d3a02aa993c7474297e33d992f39ad0 : GenericRecordList<RC_deb85dc36640fa928dae5df2493065d0>, IEnumerable, IEnumerator {

protected override RC_deb85dc36640fa928dae5df2493065d0 GetElementDefaultValue() {
return new RC_deb85dc36640fa928dae5df2493065d0();
}

public T[] ToArray<T>(Func<RC_deb85dc36640fa928dae5df2493065d0, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_5d3a02aa993c7474297e33d992f39ad0 recordList, Func<RC_deb85dc36640fa928dae5df2493065d0, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_5d3a02aa993c7474297e33d992f39ad0(RC_deb85dc36640fa928dae5df2493065d0[] array) {
  RL_5d3a02aa993c7474297e33d992f39ad0 result = new RL_5d3a02aa993c7474297e33d992f39ad0();
result.InnerFromArray(array);
    return result;
}

public static RL_5d3a02aa993c7474297e33d992f39ad0 ToList<T>(T[] array, Func <T, RC_deb85dc36640fa928dae5df2493065d0> converter) {
  RL_5d3a02aa993c7474297e33d992f39ad0 result = new RL_5d3a02aa993c7474297e33d992f39ad0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_5d3a02aa993c7474297e33d992f39ad0 FromRestList<T>(RestList<T> restList, Func <T, RC_deb85dc36640fa928dae5df2493065d0> converter) {
  RL_5d3a02aa993c7474297e33d992f39ad0 result = new RL_5d3a02aa993c7474297e33d992f39ad0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_5d3a02aa993c7474297e33d992f39ad0() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_deb85dc36640fa928dae5df2493065d0> NewList() {
return new RL_5d3a02aa993c7474297e33d992f39ad0();
}


} // RL_5d3a02aa993c7474297e33d992f39ad0
}

