namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (8wFYOtkkM0KpERDBnO+SzQ)
///  <code>RC_a18bcaa92353126e3b75741517eabbdb</code> that represent
/// s <code>SpecialPostDeliveryAuthorizationRecord</code> <p>Description: </p>
/// </summary>
// Name: SpecialPostDeliveryAuthorizationRecord
public partial struct RC_a18bcaa92353126e3b75741517eabbdb : ITypedRecord<RC_a18bcaa92353126e3b75741517eabbdb> {
internal static readonly GlobalObjectKey IdSpecialPostDeliveryAuthorization = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qcqLoVMjbhI7dXQVF+q72w");

public EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord ssENSpecialPostDeliveryAuthorization;


public static implicit operator EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord( RC_a18bcaa92353126e3b75741517eabbdb r) {
return r.ssENSpecialPostDeliveryAuthorization;
}

public static implicit operator RC_a18bcaa92353126e3b75741517eabbdb (EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord r) {
RC_a18bcaa92353126e3b75741517eabbdb res = new RC_a18bcaa92353126e3b75741517eabbdb ();
res.ssENSpecialPostDeliveryAuthorization = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSpecialPostDeliveryAuthorization.ChangedAttributes = value;
}
get {
    return ssENSpecialPostDeliveryAuthorization.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_a18bcaa92353126e3b75741517eabbdb() {
OptimizedAttributes = null;
ssENSpecialPostDeliveryAuthorization = new EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSpecialPostDeliveryAuthorization.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSpecialPostDeliveryAuthorization.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSpecialPostDeliveryAuthorization.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSpecialPostDeliveryAuthorization.Read( r, ref index);
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
public void ReadIM(RC_a18bcaa92353126e3b75741517eabbdb r) {
this = r;
}


public static bool operator == (RC_a18bcaa92353126e3b75741517eabbdb a, RC_a18bcaa92353126e3b75741517eabbdb b) {
if (a.ssENSpecialPostDeliveryAuthorization != b.ssENSpecialPostDeliveryAuthorization) return false;
return true;
}

public static bool operator != (RC_a18bcaa92353126e3b75741517eabbdb a, RC_a18bcaa92353126e3b75741517eabbdb b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_a18bcaa92353126e3b75741517eabbdb)) return false;
return (this == (RC_a18bcaa92353126e3b75741517eabbdb)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSpecialPostDeliveryAuthorization.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSpecialPostDeliveryAuthorization.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSpecialPostDeliveryAuthorization.InternalRecursiveSave();
}


public RC_a18bcaa92353126e3b75741517eabbdb Duplicate() {
RC_a18bcaa92353126e3b75741517eabbdb t;
t.ssENSpecialPostDeliveryAuthorization = (EN_b0cf3ee36985920f2fdff1dbd2e94fb9EntityRecord)this.ssENSpecialPostDeliveryAuthorization.Duplicate();
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
if (head == "specialpostdeliveryauthorization") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialPostDeliveryAuthorization")) variable.Value = ssENSpecialPostDeliveryAuthorization; else variable.Optimized = true;
variable.SetFieldName("specialpostdeliveryauthorization");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialPostDeliveryAuthorization.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialPostDeliveryAuthorization.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpecialPostDeliveryAuthorization) {
return ssENSpecialPostDeliveryAuthorization;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpecialPostDeliveryAuthorization.Key.AsGuid) {
return ssENSpecialPostDeliveryAuthorization;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSpecialPostDeliveryAuthorization.FillFromOther((IRecord) other.AttributeGet(IdSpecialPostDeliveryAuthorization));
}
} // RC_a18bcaa92353126e3b75741517eabbdb
/// <summary>
/// RecordList type <code>SpecialPostDeliveryAuthorizationRecordList</code> that represents a record
///  list of <code>SpecialPostDeliveryAuthorization</code>
/// </summary>
public partial class RL_9a84f0ca43f575461143a73bcb506dba : GenericRecordList<RC_a18bcaa92353126e3b75741517eabbdb>, IEnumerable, IEnumerator {

protected override RC_a18bcaa92353126e3b75741517eabbdb GetElementDefaultValue() {
return new RC_a18bcaa92353126e3b75741517eabbdb();
}

public T[] ToArray<T>(Func<RC_a18bcaa92353126e3b75741517eabbdb, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9a84f0ca43f575461143a73bcb506dba recordList, Func<RC_a18bcaa92353126e3b75741517eabbdb, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9a84f0ca43f575461143a73bcb506dba(RC_a18bcaa92353126e3b75741517eabbdb[] array) {
  RL_9a84f0ca43f575461143a73bcb506dba result = new RL_9a84f0ca43f575461143a73bcb506dba();
result.InnerFromArray(array);
    return result;
}

public static RL_9a84f0ca43f575461143a73bcb506dba ToList<T>(T[] array, Func <T, RC_a18bcaa92353126e3b75741517eabbdb> converter) {
  RL_9a84f0ca43f575461143a73bcb506dba result = new RL_9a84f0ca43f575461143a73bcb506dba();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9a84f0ca43f575461143a73bcb506dba FromRestList<T>(RestList<T> restList, Func <T, RC_a18bcaa92353126e3b75741517eabbdb> converter) {
  RL_9a84f0ca43f575461143a73bcb506dba result = new RL_9a84f0ca43f575461143a73bcb506dba();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9a84f0ca43f575461143a73bcb506dba() : base() {
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
protected override OSList<RC_a18bcaa92353126e3b75741517eabbdb> NewList() {
return new RL_9a84f0ca43f575461143a73bcb506dba();
}


} // RL_9a84f0ca43f575461143a73bcb506dba
}

