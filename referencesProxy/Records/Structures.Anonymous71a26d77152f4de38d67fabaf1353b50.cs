namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (d22icS8V402NZ_q68TU7UA)
///  <code>RC_261685da2c799bcc3b4873485e008694</code> that represents <code>BreakColumnsRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: BreakColumnsRecord
public partial struct RC_261685da2c799bcc3b4873485e008694 : ITypedRecord<RC_261685da2c799bcc3b4873485e008694> {
internal static readonly GlobalObjectKey IdBreakColumns = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*2oUWJnkszJs7SHNIXgCGlA");

public EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord ssENBreakColumns;


public static implicit operator EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord( RC_261685da2c799bcc3b4873485e008694 r) {
return r.ssENBreakColumns;
}

public static implicit operator RC_261685da2c799bcc3b4873485e008694 (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord r) {
RC_261685da2c799bcc3b4873485e008694 res = new RC_261685da2c799bcc3b4873485e008694 ();
res.ssENBreakColumns = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENBreakColumns.ChangedAttributes = value;
}
get {
    return ssENBreakColumns.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_261685da2c799bcc3b4873485e008694() {
OptimizedAttributes = null;
ssENBreakColumns = new EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENBreakColumns.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENBreakColumns.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENBreakColumns.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENBreakColumns.Read( r, ref index);
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
public void ReadIM(RC_261685da2c799bcc3b4873485e008694 r) {
this = r;
}


public static bool operator == (RC_261685da2c799bcc3b4873485e008694 a, RC_261685da2c799bcc3b4873485e008694 b) {
if (a.ssENBreakColumns != b.ssENBreakColumns) return false;
return true;
}

public static bool operator != (RC_261685da2c799bcc3b4873485e008694 a, RC_261685da2c799bcc3b4873485e008694 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_261685da2c799bcc3b4873485e008694)) return false;
return (this == (RC_261685da2c799bcc3b4873485e008694)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENBreakColumns.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENBreakColumns.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENBreakColumns.InternalRecursiveSave();
}


public RC_261685da2c799bcc3b4873485e008694 Duplicate() {
RC_261685da2c799bcc3b4873485e008694 t;
t.ssENBreakColumns = (EN_182bd2d69e3f1edb7f1fb76efcbcae87EntityRecord)this.ssENBreakColumns.Duplicate();
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
if (head == "breakcolumns") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".BreakColumns")) variable.Value = ssENBreakColumns; else variable.Optimized = true;
variable.SetFieldName("breakcolumns");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENBreakColumns.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENBreakColumns.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdBreakColumns) {
return ssENBreakColumns;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdBreakColumns.Key.AsGuid) {
return ssENBreakColumns;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENBreakColumns.FillFromOther((IRecord) other.AttributeGet(IdBreakColumns));
}
} // RC_261685da2c799bcc3b4873485e008694
/// <summary>
/// RecordList type <code>BreakColumnsRecordList</code> that represents a record list of
///  <code>BreakColumns</code>
/// </summary>
public partial class RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 : GenericRecordList<RC_261685da2c799bcc3b4873485e008694>, IEnumerable, IEnumerator {

protected override RC_261685da2c799bcc3b4873485e008694 GetElementDefaultValue() {
return new RC_261685da2c799bcc3b4873485e008694();
}

public T[] ToArray<T>(Func<RC_261685da2c799bcc3b4873485e008694, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 recordList, Func<RC_261685da2c799bcc3b4873485e008694, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_4f6dde27a1d6ecd82e9d6a4d041d32f3(RC_261685da2c799bcc3b4873485e008694[] array) {
  RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 result = new RL_4f6dde27a1d6ecd82e9d6a4d041d32f3();
result.InnerFromArray(array);
    return result;
}

public static RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 ToList<T>(T[] array, Func <T, RC_261685da2c799bcc3b4873485e008694> converter) {
  RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 result = new RL_4f6dde27a1d6ecd82e9d6a4d041d32f3();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 FromRestList<T>(RestList<T> restList, Func <T, RC_261685da2c799bcc3b4873485e008694> converter) {
  RL_4f6dde27a1d6ecd82e9d6a4d041d32f3 result = new RL_4f6dde27a1d6ecd82e9d6a4d041d32f3();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_4f6dde27a1d6ecd82e9d6a4d041d32f3() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_261685da2c799bcc3b4873485e008694> NewList() {
return new RL_4f6dde27a1d6ecd82e9d6a4d041d32f3();
}


} // RL_4f6dde27a1d6ecd82e9d6a4d041d32f3
}

