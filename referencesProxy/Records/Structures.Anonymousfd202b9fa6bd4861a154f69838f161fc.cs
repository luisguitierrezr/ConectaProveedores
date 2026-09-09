namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (nysg_b2mYUihVPaYOPFh_A)
///  <code>RC_b80982ac17cf476fb15d90ab7992f505</code> that represents <code>DayOfWeekRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: DayOfWeekRecord
public partial struct RC_b80982ac17cf476fb15d90ab7992f505 : ITypedRecord<RC_b80982ac17cf476fb15d90ab7992f505> {
internal static readonly GlobalObjectKey IdDayOfWeek = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*rIIJuM8Xb0exXZCreZL1BQ");

public EN_994a40086cd6e8196835f26327ddf330EntityRecord ssENDayOfWeek;


public static implicit operator EN_994a40086cd6e8196835f26327ddf330EntityRecord( RC_b80982ac17cf476fb15d90ab7992f505 r) {
return r.ssENDayOfWeek;
}

public static implicit operator RC_b80982ac17cf476fb15d90ab7992f505 (EN_994a40086cd6e8196835f26327ddf330EntityRecord r) {
RC_b80982ac17cf476fb15d90ab7992f505 res = new RC_b80982ac17cf476fb15d90ab7992f505 ();
res.ssENDayOfWeek = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENDayOfWeek.ChangedAttributes = value;
}
get {
    return ssENDayOfWeek.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_b80982ac17cf476fb15d90ab7992f505() {
OptimizedAttributes = null;
ssENDayOfWeek = new EN_994a40086cd6e8196835f26327ddf330EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENDayOfWeek.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENDayOfWeek.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENDayOfWeek.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENDayOfWeek.Read( r, ref index);
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
public void ReadIM(RC_b80982ac17cf476fb15d90ab7992f505 r) {
this = r;
}


public static bool operator == (RC_b80982ac17cf476fb15d90ab7992f505 a, RC_b80982ac17cf476fb15d90ab7992f505 b) {
if (a.ssENDayOfWeek != b.ssENDayOfWeek) return false;
return true;
}

public static bool operator != (RC_b80982ac17cf476fb15d90ab7992f505 a, RC_b80982ac17cf476fb15d90ab7992f505 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b80982ac17cf476fb15d90ab7992f505)) return false;
return (this == (RC_b80982ac17cf476fb15d90ab7992f505)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENDayOfWeek.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENDayOfWeek.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENDayOfWeek.InternalRecursiveSave();
}


public RC_b80982ac17cf476fb15d90ab7992f505 Duplicate() {
RC_b80982ac17cf476fb15d90ab7992f505 t;
t.ssENDayOfWeek = (EN_994a40086cd6e8196835f26327ddf330EntityRecord)this.ssENDayOfWeek.Duplicate();
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
if (head == "dayofweek") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".DayOfWeek")) variable.Value = ssENDayOfWeek; else variable.Optimized = true;
variable.SetFieldName("dayofweek");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENDayOfWeek.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENDayOfWeek.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdDayOfWeek) {
return ssENDayOfWeek;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdDayOfWeek.Key.AsGuid) {
return ssENDayOfWeek;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENDayOfWeek.FillFromOther((IRecord) other.AttributeGet(IdDayOfWeek));
}
} // RC_b80982ac17cf476fb15d90ab7992f505
/// <summary>
/// RecordList type <code>DayOfWeekRecordList</code> that represents a record list of
///  <code>DayOfWeek</code>
/// </summary>
public partial class RL_6f8962eed7c4ac68df44ff30c6dee7db : GenericRecordList<RC_b80982ac17cf476fb15d90ab7992f505>, IEnumerable, IEnumerator {

protected override RC_b80982ac17cf476fb15d90ab7992f505 GetElementDefaultValue() {
return new RC_b80982ac17cf476fb15d90ab7992f505();
}

public T[] ToArray<T>(Func<RC_b80982ac17cf476fb15d90ab7992f505, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_6f8962eed7c4ac68df44ff30c6dee7db recordList, Func<RC_b80982ac17cf476fb15d90ab7992f505, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_6f8962eed7c4ac68df44ff30c6dee7db(RC_b80982ac17cf476fb15d90ab7992f505[] array) {
  RL_6f8962eed7c4ac68df44ff30c6dee7db result = new RL_6f8962eed7c4ac68df44ff30c6dee7db();
result.InnerFromArray(array);
    return result;
}

public static RL_6f8962eed7c4ac68df44ff30c6dee7db ToList<T>(T[] array, Func <T, RC_b80982ac17cf476fb15d90ab7992f505> converter) {
  RL_6f8962eed7c4ac68df44ff30c6dee7db result = new RL_6f8962eed7c4ac68df44ff30c6dee7db();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_6f8962eed7c4ac68df44ff30c6dee7db FromRestList<T>(RestList<T> restList, Func <T, RC_b80982ac17cf476fb15d90ab7992f505> converter) {
  RL_6f8962eed7c4ac68df44ff30c6dee7db result = new RL_6f8962eed7c4ac68df44ff30c6dee7db();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_6f8962eed7c4ac68df44ff30c6dee7db() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(4,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_b80982ac17cf476fb15d90ab7992f505> NewList() {
return new RL_6f8962eed7c4ac68df44ff30c6dee7db();
}


} // RL_6f8962eed7c4ac68df44ff30c6dee7db
}

