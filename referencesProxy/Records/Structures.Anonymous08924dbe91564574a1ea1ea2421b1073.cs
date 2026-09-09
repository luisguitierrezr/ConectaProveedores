namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (vk2SCFaRdEWh6h6iQhsQcw)
///  <code>RC_1356565a59d37b0a56b61edcf3cae9df</code> that represents <code>ServiceFormatRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ServiceFormatRecord
public partial struct RC_1356565a59d37b0a56b61edcf3cae9df : ITypedRecord<RC_1356565a59d37b0a56b61edcf3cae9df> {
internal static readonly GlobalObjectKey IdServiceFormat = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*WlZWE9NZCntWth7c88rp3w");

public EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord ssENServiceFormat;


public static implicit operator EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord( RC_1356565a59d37b0a56b61edcf3cae9df r) {
return r.ssENServiceFormat;
}

public static implicit operator RC_1356565a59d37b0a56b61edcf3cae9df (EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord r) {
RC_1356565a59d37b0a56b61edcf3cae9df res = new RC_1356565a59d37b0a56b61edcf3cae9df ();
res.ssENServiceFormat = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENServiceFormat.ChangedAttributes = value;
}
get {
    return ssENServiceFormat.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_1356565a59d37b0a56b61edcf3cae9df() {
OptimizedAttributes = null;
ssENServiceFormat = new EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(6,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENServiceFormat.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENServiceFormat.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENServiceFormat.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENServiceFormat.Read( r, ref index);
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
public void ReadIM(RC_1356565a59d37b0a56b61edcf3cae9df r) {
this = r;
}


public static bool operator == (RC_1356565a59d37b0a56b61edcf3cae9df a, RC_1356565a59d37b0a56b61edcf3cae9df b) {
if (a.ssENServiceFormat != b.ssENServiceFormat) return false;
return true;
}

public static bool operator != (RC_1356565a59d37b0a56b61edcf3cae9df a, RC_1356565a59d37b0a56b61edcf3cae9df b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_1356565a59d37b0a56b61edcf3cae9df)) return false;
return (this == (RC_1356565a59d37b0a56b61edcf3cae9df)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENServiceFormat.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENServiceFormat.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENServiceFormat.InternalRecursiveSave();
}


public RC_1356565a59d37b0a56b61edcf3cae9df Duplicate() {
RC_1356565a59d37b0a56b61edcf3cae9df t;
t.ssENServiceFormat = (EN_90b73a13d9271bc660c79c0da31f8dbbEntityRecord)this.ssENServiceFormat.Duplicate();
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
if (head == "serviceformat") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".ServiceFormat")) variable.Value = ssENServiceFormat; else variable.Optimized = true;
variable.SetFieldName("serviceformat");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENServiceFormat.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENServiceFormat.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdServiceFormat) {
return ssENServiceFormat;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdServiceFormat.Key.AsGuid) {
return ssENServiceFormat;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENServiceFormat.FillFromOther((IRecord) other.AttributeGet(IdServiceFormat));
}
} // RC_1356565a59d37b0a56b61edcf3cae9df
/// <summary>
/// RecordList type <code>ServiceFormatRecordList</code> that represents a record list of
///  <code>ServiceFormat</code>
/// </summary>
public partial class RL_2ce058321dad3f60357fc3b3372ccb1e : GenericRecordList<RC_1356565a59d37b0a56b61edcf3cae9df>, IEnumerable, IEnumerator {

protected override RC_1356565a59d37b0a56b61edcf3cae9df GetElementDefaultValue() {
return new RC_1356565a59d37b0a56b61edcf3cae9df();
}

public T[] ToArray<T>(Func<RC_1356565a59d37b0a56b61edcf3cae9df, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2ce058321dad3f60357fc3b3372ccb1e recordList, Func<RC_1356565a59d37b0a56b61edcf3cae9df, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2ce058321dad3f60357fc3b3372ccb1e(RC_1356565a59d37b0a56b61edcf3cae9df[] array) {
  RL_2ce058321dad3f60357fc3b3372ccb1e result = new RL_2ce058321dad3f60357fc3b3372ccb1e();
result.InnerFromArray(array);
    return result;
}

public static RL_2ce058321dad3f60357fc3b3372ccb1e ToList<T>(T[] array, Func <T, RC_1356565a59d37b0a56b61edcf3cae9df> converter) {
  RL_2ce058321dad3f60357fc3b3372ccb1e result = new RL_2ce058321dad3f60357fc3b3372ccb1e();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2ce058321dad3f60357fc3b3372ccb1e FromRestList<T>(RestList<T> restList, Func <T, RC_1356565a59d37b0a56b61edcf3cae9df> converter) {
  RL_2ce058321dad3f60357fc3b3372ccb1e result = new RL_2ce058321dad3f60357fc3b3372ccb1e();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2ce058321dad3f60357fc3b3372ccb1e() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(6,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_1356565a59d37b0a56b61edcf3cae9df> NewList() {
return new RL_2ce058321dad3f60357fc3b3372ccb1e();
}


} // RL_2ce058321dad3f60357fc3b3372ccb1e
}

