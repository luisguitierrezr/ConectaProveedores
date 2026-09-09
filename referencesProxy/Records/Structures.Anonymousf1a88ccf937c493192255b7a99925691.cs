namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (z4yo8XyTMUmSJVt6mZJWkQ)
///  <code>RC_1fb80539f98a7ca912363f5e5c822271</code> that represents <code>MarginSizeRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: MarginSizeRecord
public partial struct RC_1fb80539f98a7ca912363f5e5c822271 : ITypedRecord<RC_1fb80539f98a7ca912363f5e5c822271> {
internal static readonly GlobalObjectKey IdMarginSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*OQW4H4r5qXwSNj9eXIIicQ");

public EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord ssENMarginSize;


public static implicit operator EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord( RC_1fb80539f98a7ca912363f5e5c822271 r) {
return r.ssENMarginSize;
}

public static implicit operator RC_1fb80539f98a7ca912363f5e5c822271 (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord r) {
RC_1fb80539f98a7ca912363f5e5c822271 res = new RC_1fb80539f98a7ca912363f5e5c822271 ();
res.ssENMarginSize = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENMarginSize.ChangedAttributes = value;
}
get {
    return ssENMarginSize.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1fb80539f98a7ca912363f5e5c822271() {
OptimizedAttributes = null;
ssENMarginSize = new EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENMarginSize.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENMarginSize.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENMarginSize.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENMarginSize.Read( r, ref index);
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
public void ReadIM(RC_1fb80539f98a7ca912363f5e5c822271 r) {
this = r;
}


public static bool operator == (RC_1fb80539f98a7ca912363f5e5c822271 a, RC_1fb80539f98a7ca912363f5e5c822271 b) {
if (a.ssENMarginSize != b.ssENMarginSize) return false;
return true;
}

public static bool operator != (RC_1fb80539f98a7ca912363f5e5c822271 a, RC_1fb80539f98a7ca912363f5e5c822271 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1fb80539f98a7ca912363f5e5c822271)) return false;
return (this == (RC_1fb80539f98a7ca912363f5e5c822271)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENMarginSize.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENMarginSize.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENMarginSize.InternalRecursiveSave();
}


public RC_1fb80539f98a7ca912363f5e5c822271 Duplicate() {
RC_1fb80539f98a7ca912363f5e5c822271 t;
t.ssENMarginSize = (EN_bc12735cadf5fd97cab6601d74d436e8EntityRecord)this.ssENMarginSize.Duplicate();
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
if (head == "marginsize") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".MarginSize")) variable.Value = ssENMarginSize; else variable.Optimized = true;
variable.SetFieldName("marginsize");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENMarginSize.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENMarginSize.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdMarginSize) {
return ssENMarginSize;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdMarginSize.Key.AsGuid) {
return ssENMarginSize;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENMarginSize.FillFromOther((IRecord) other.AttributeGet(IdMarginSize));
}
} // RC_1fb80539f98a7ca912363f5e5c822271
/// <summary>
/// RecordList type <code>MarginSizeRecordList</code> that represents a record list of
///  <code>MarginSize</code>
/// </summary>
public partial class RL_d466dcfe8fa0d18063c76dc973ef1e26 : GenericRecordList<RC_1fb80539f98a7ca912363f5e5c822271>, IEnumerable, IEnumerator {

protected override RC_1fb80539f98a7ca912363f5e5c822271 GetElementDefaultValue() {
return new RC_1fb80539f98a7ca912363f5e5c822271();
}

public T[] ToArray<T>(Func<RC_1fb80539f98a7ca912363f5e5c822271, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_d466dcfe8fa0d18063c76dc973ef1e26 recordList, Func<RC_1fb80539f98a7ca912363f5e5c822271, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_d466dcfe8fa0d18063c76dc973ef1e26(RC_1fb80539f98a7ca912363f5e5c822271[] array) {
  RL_d466dcfe8fa0d18063c76dc973ef1e26 result = new RL_d466dcfe8fa0d18063c76dc973ef1e26();
result.InnerFromArray(array);
    return result;
}

public static RL_d466dcfe8fa0d18063c76dc973ef1e26 ToList<T>(T[] array, Func <T, RC_1fb80539f98a7ca912363f5e5c822271> converter) {
  RL_d466dcfe8fa0d18063c76dc973ef1e26 result = new RL_d466dcfe8fa0d18063c76dc973ef1e26();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_d466dcfe8fa0d18063c76dc973ef1e26 FromRestList<T>(RestList<T> restList, Func <T, RC_1fb80539f98a7ca912363f5e5c822271> converter) {
  RL_d466dcfe8fa0d18063c76dc973ef1e26 result = new RL_d466dcfe8fa0d18063c76dc973ef1e26();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_d466dcfe8fa0d18063c76dc973ef1e26() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1fb80539f98a7ca912363f5e5c822271> NewList() {
return new RL_d466dcfe8fa0d18063c76dc973ef1e26();
}


} // RL_d466dcfe8fa0d18063c76dc973ef1e26
}

