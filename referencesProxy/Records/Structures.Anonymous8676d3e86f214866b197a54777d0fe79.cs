namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (6NN2hiFvZkixl6VHd9D+eQ)
///  <code>RC_0a89eeb60fa1f44b6316ca69b462007b</code> that represents <code>ShapeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ShapeRecord
public partial struct RC_0a89eeb60fa1f44b6316ca69b462007b : ITypedRecord<RC_0a89eeb60fa1f44b6316ca69b462007b> {
internal static readonly GlobalObjectKey IdShape = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tu6JCqEPS_RjFspptGIAew");

public EN_d11562be18a7e40ca777aa336c946163EntityRecord ssENShape;


public static implicit operator EN_d11562be18a7e40ca777aa336c946163EntityRecord( RC_0a89eeb60fa1f44b6316ca69b462007b r) {
return r.ssENShape;
}

public static implicit operator RC_0a89eeb60fa1f44b6316ca69b462007b (EN_d11562be18a7e40ca777aa336c946163EntityRecord r) {
RC_0a89eeb60fa1f44b6316ca69b462007b res = new RC_0a89eeb60fa1f44b6316ca69b462007b ();
res.ssENShape = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENShape.ChangedAttributes = value;
}
get {
    return ssENShape.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_0a89eeb60fa1f44b6316ca69b462007b() {
OptimizedAttributes = null;
ssENShape = new EN_d11562be18a7e40ca777aa336c946163EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENShape.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENShape.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENShape.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENShape.Read( r, ref index);
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
public void ReadIM(RC_0a89eeb60fa1f44b6316ca69b462007b r) {
this = r;
}


public static bool operator == (RC_0a89eeb60fa1f44b6316ca69b462007b a, RC_0a89eeb60fa1f44b6316ca69b462007b b) {
if (a.ssENShape != b.ssENShape) return false;
return true;
}

public static bool operator != (RC_0a89eeb60fa1f44b6316ca69b462007b a, RC_0a89eeb60fa1f44b6316ca69b462007b b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0a89eeb60fa1f44b6316ca69b462007b)) return false;
return (this == (RC_0a89eeb60fa1f44b6316ca69b462007b)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENShape.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENShape.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENShape.InternalRecursiveSave();
}


public RC_0a89eeb60fa1f44b6316ca69b462007b Duplicate() {
RC_0a89eeb60fa1f44b6316ca69b462007b t;
t.ssENShape = (EN_d11562be18a7e40ca777aa336c946163EntityRecord)this.ssENShape.Duplicate();
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
if (head == "shape") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Shape")) variable.Value = ssENShape; else variable.Optimized = true;
variable.SetFieldName("shape");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENShape.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENShape.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdShape) {
return ssENShape;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdShape.Key.AsGuid) {
return ssENShape;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENShape.FillFromOther((IRecord) other.AttributeGet(IdShape));
}
} // RC_0a89eeb60fa1f44b6316ca69b462007b
/// <summary>
/// RecordList type <code>ShapeRecordList</code> that represents a record list of <code>Shape</code>
/// </summary>
public partial class RL_6753b1849ff4bc19e62c553317f17751 : GenericRecordList<RC_0a89eeb60fa1f44b6316ca69b462007b>, IEnumerable, IEnumerator {

protected override RC_0a89eeb60fa1f44b6316ca69b462007b GetElementDefaultValue() {
return new RC_0a89eeb60fa1f44b6316ca69b462007b();
}

public T[] ToArray<T>(Func<RC_0a89eeb60fa1f44b6316ca69b462007b, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6753b1849ff4bc19e62c553317f17751 recordList, Func<RC_0a89eeb60fa1f44b6316ca69b462007b, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6753b1849ff4bc19e62c553317f17751(RC_0a89eeb60fa1f44b6316ca69b462007b[] array) {
  RL_6753b1849ff4bc19e62c553317f17751 result = new RL_6753b1849ff4bc19e62c553317f17751();
result.InnerFromArray(array);
    return result;
}

public static RL_6753b1849ff4bc19e62c553317f17751 ToList<T>(T[] array, Func <T, RC_0a89eeb60fa1f44b6316ca69b462007b> converter) {
  RL_6753b1849ff4bc19e62c553317f17751 result = new RL_6753b1849ff4bc19e62c553317f17751();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6753b1849ff4bc19e62c553317f17751 FromRestList<T>(RestList<T> restList, Func <T, RC_0a89eeb60fa1f44b6316ca69b462007b> converter) {
  RL_6753b1849ff4bc19e62c553317f17751 result = new RL_6753b1849ff4bc19e62c553317f17751();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6753b1849ff4bc19e62c553317f17751() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0a89eeb60fa1f44b6316ca69b462007b> NewList() {
return new RL_6753b1849ff4bc19e62c553317f17751();
}


} // RL_6753b1849ff4bc19e62c553317f17751
}

