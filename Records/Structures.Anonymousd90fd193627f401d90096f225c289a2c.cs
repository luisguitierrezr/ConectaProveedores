namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (k9EP2X9iHUCQCW8iXCiaLA)
///  <code>RC_5860726e4142bb2973b9ba88d317465f</code> that represent
/// s <code>RequisitionAccountingRecord</code> <p>Description: </p>
/// </summary>
// Name: RequisitionAccountingRecord
public partial struct RC_5860726e4142bb2973b9ba88d317465f : ITypedRecord<RC_5860726e4142bb2973b9ba88d317465f> {
internal static readonly GlobalObjectKey IdRequisitionAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bnJgWEJBKbtzubqI0xdGXw");

public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord ssENRequisitionAccounting;


public static implicit operator EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord( RC_5860726e4142bb2973b9ba88d317465f r) {
return r.ssENRequisitionAccounting;
}

public static implicit operator RC_5860726e4142bb2973b9ba88d317465f (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord r) {
RC_5860726e4142bb2973b9ba88d317465f res = new RC_5860726e4142bb2973b9ba88d317465f ();
res.ssENRequisitionAccounting = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENRequisitionAccounting.ChangedAttributes = value;
}
get {
    return ssENRequisitionAccounting.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_5860726e4142bb2973b9ba88d317465f() {
OptimizedAttributes = null;
ssENRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(19,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENRequisitionAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENRequisitionAccounting.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENRequisitionAccounting.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENRequisitionAccounting.Read( r, ref index);
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
public void ReadIM(RC_5860726e4142bb2973b9ba88d317465f r) {
this = r;
}


public static bool operator == (RC_5860726e4142bb2973b9ba88d317465f a, RC_5860726e4142bb2973b9ba88d317465f b) {
if (a.ssENRequisitionAccounting != b.ssENRequisitionAccounting) return false;
return true;
}

public static bool operator != (RC_5860726e4142bb2973b9ba88d317465f a, RC_5860726e4142bb2973b9ba88d317465f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5860726e4142bb2973b9ba88d317465f)) return false;
return (this == (RC_5860726e4142bb2973b9ba88d317465f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENRequisitionAccounting.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENRequisitionAccounting.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENRequisitionAccounting.InternalRecursiveSave();
}


public RC_5860726e4142bb2973b9ba88d317465f Duplicate() {
RC_5860726e4142bb2973b9ba88d317465f t;
t.ssENRequisitionAccounting = (EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord)this.ssENRequisitionAccounting.Duplicate();
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
if (head == "requisitionaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RequisitionAccounting")) variable.Value = ssENRequisitionAccounting; else variable.Optimized = true;
variable.SetFieldName("requisitionaccounting");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionAccounting.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENRequisitionAccounting.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdRequisitionAccounting) {
return ssENRequisitionAccounting;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdRequisitionAccounting.Key.AsGuid) {
return ssENRequisitionAccounting;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENRequisitionAccounting.FillFromOther((IRecord) other.AttributeGet(IdRequisitionAccounting));
}
} // RC_5860726e4142bb2973b9ba88d317465f
/// <summary>
/// RecordList type <code>RequisitionAccountingRecordList</code> that represents a record list of
///  <code>RequisitionAccounting</code>
/// </summary>
public partial class RL_991db829ff4e7fe204109f106256f023 : GenericRecordList<RC_5860726e4142bb2973b9ba88d317465f>, IEnumerable, IEnumerator {

protected override RC_5860726e4142bb2973b9ba88d317465f GetElementDefaultValue() {
return new RC_5860726e4142bb2973b9ba88d317465f();
}

public T[] ToArray<T>(Func<RC_5860726e4142bb2973b9ba88d317465f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_991db829ff4e7fe204109f106256f023 recordList, Func<RC_5860726e4142bb2973b9ba88d317465f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_991db829ff4e7fe204109f106256f023(RC_5860726e4142bb2973b9ba88d317465f[] array) {
  RL_991db829ff4e7fe204109f106256f023 result = new RL_991db829ff4e7fe204109f106256f023();
result.InnerFromArray(array);
    return result;
}

public static RL_991db829ff4e7fe204109f106256f023 ToList<T>(T[] array, Func <T, RC_5860726e4142bb2973b9ba88d317465f> converter) {
  RL_991db829ff4e7fe204109f106256f023 result = new RL_991db829ff4e7fe204109f106256f023();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_991db829ff4e7fe204109f106256f023 FromRestList<T>(RestList<T> restList, Func <T, RC_5860726e4142bb2973b9ba88d317465f> converter) {
  RL_991db829ff4e7fe204109f106256f023 result = new RL_991db829ff4e7fe204109f106256f023();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_991db829ff4e7fe204109f106256f023() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(19,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5860726e4142bb2973b9ba88d317465f> NewList() {
return new RL_991db829ff4e7fe204109f106256f023();
}


} // RL_991db829ff4e7fe204109f106256f023
}

