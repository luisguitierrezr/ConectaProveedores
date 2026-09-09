namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (vRBLWy_Yt0aTnYcDKxjZLg)
///  <code>RC_db6241df01dbf5b6e7aa17fd129f947a</code> that represent
/// s <code>DocumentExtrationSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: DocumentExtrationSupplierRecord
public partial struct RC_db6241df01dbf5b6e7aa17fd129f947a : ITypedRecord<RC_db6241df01dbf5b6e7aa17fd129f947a> {
internal static readonly GlobalObjectKey IdDocumentExtrationSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*30Fi29sBtvXnqhf9Ep+Ueg");

public ST_c1e66f019db37ad740f84fa58db915f9Structure ssSTDocumentExtrationSupplier;


public static implicit operator ST_c1e66f019db37ad740f84fa58db915f9Structure( RC_db6241df01dbf5b6e7aa17fd129f947a r) {
return r.ssSTDocumentExtrationSupplier;
}

public static implicit operator RC_db6241df01dbf5b6e7aa17fd129f947a (ST_c1e66f019db37ad740f84fa58db915f9Structure r) {
RC_db6241df01dbf5b6e7aa17fd129f947a res = new RC_db6241df01dbf5b6e7aa17fd129f947a ();
res.ssSTDocumentExtrationSupplier = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_db6241df01dbf5b6e7aa17fd129f947a() {
OptimizedAttributes = null;
ssSTDocumentExtrationSupplier = new ST_c1e66f019db37ad740f84fa58db915f9Structure();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    ssSTDocumentExtrationSupplier.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = null;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssSTDocumentExtrationSupplier.Read( r, ref index);
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
public void ReadIM(RC_db6241df01dbf5b6e7aa17fd129f947a r) {
this = r;
}


public static bool operator == (RC_db6241df01dbf5b6e7aa17fd129f947a a, RC_db6241df01dbf5b6e7aa17fd129f947a b) {
if (a.ssSTDocumentExtrationSupplier != b.ssSTDocumentExtrationSupplier) return false;
return true;
}

public static bool operator != (RC_db6241df01dbf5b6e7aa17fd129f947a a, RC_db6241df01dbf5b6e7aa17fd129f947a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_db6241df01dbf5b6e7aa17fd129f947a)) return false;
return (this == (RC_db6241df01dbf5b6e7aa17fd129f947a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTDocumentExtrationSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTDocumentExtrationSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTDocumentExtrationSupplier.InternalRecursiveSave();
}


public RC_db6241df01dbf5b6e7aa17fd129f947a Duplicate() {
RC_db6241df01dbf5b6e7aa17fd129f947a t;
t.ssSTDocumentExtrationSupplier = (ST_c1e66f019db37ad740f84fa58db915f9Structure)this.ssSTDocumentExtrationSupplier.Duplicate();
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
if (head == "documentextrationsupplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DocumentExtrationSupplier")) variable.Value = ssSTDocumentExtrationSupplier; else variable.Optimized = true;
variable.SetFieldName("documentextrationsupplier");
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
if (key == IdDocumentExtrationSupplier) {
return ssSTDocumentExtrationSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDocumentExtrationSupplier.Key.AsGuid) {
return ssSTDocumentExtrationSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTDocumentExtrationSupplier.FillFromOther((IRecord) other.AttributeGet(IdDocumentExtrationSupplier));
}
} // RC_db6241df01dbf5b6e7aa17fd129f947a
/// <summary>
/// RecordList type <code>DocumentExtrationSupplierRecordList</code> that represents a record list of
///  <code>DocumentExtrationSupplier</code>
/// </summary>
public partial class RL_44bf49c9152192f5688e9bc6ee64cd39 : GenericRecordList<RC_db6241df01dbf5b6e7aa17fd129f947a>, IEnumerable, IEnumerator {

protected override RC_db6241df01dbf5b6e7aa17fd129f947a GetElementDefaultValue() {
return new RC_db6241df01dbf5b6e7aa17fd129f947a();
}

public T[] ToArray<T>(Func<RC_db6241df01dbf5b6e7aa17fd129f947a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_44bf49c9152192f5688e9bc6ee64cd39 recordList, Func<RC_db6241df01dbf5b6e7aa17fd129f947a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_44bf49c9152192f5688e9bc6ee64cd39(RC_db6241df01dbf5b6e7aa17fd129f947a[] array) {
  RL_44bf49c9152192f5688e9bc6ee64cd39 result = new RL_44bf49c9152192f5688e9bc6ee64cd39();
result.InnerFromArray(array);
    return result;
}

public static RL_44bf49c9152192f5688e9bc6ee64cd39 ToList<T>(T[] array, Func <T, RC_db6241df01dbf5b6e7aa17fd129f947a> converter) {
  RL_44bf49c9152192f5688e9bc6ee64cd39 result = new RL_44bf49c9152192f5688e9bc6ee64cd39();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_44bf49c9152192f5688e9bc6ee64cd39 FromRestList<T>(RestList<T> restList, Func <T, RC_db6241df01dbf5b6e7aa17fd129f947a> converter) {
  RL_44bf49c9152192f5688e9bc6ee64cd39 result = new RL_44bf49c9152192f5688e9bc6ee64cd39();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_44bf49c9152192f5688e9bc6ee64cd39() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = null;
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_db6241df01dbf5b6e7aa17fd129f947a> NewList() {
return new RL_44bf49c9152192f5688e9bc6ee64cd39();
}


} // RL_44bf49c9152192f5688e9bc6ee64cd39
}

