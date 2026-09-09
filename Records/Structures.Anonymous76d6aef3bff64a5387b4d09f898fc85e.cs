namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (867Wdva_U0qHtNCfiY_IXg)
///  <code>RC_780ecab424bd911724518df74dd2298a</code> that represent
/// s <code>LogsAccountingSubjectRecord</code> <p>Description: </p>
/// </summary>
// Name: LogsAccountingSubjectRecord
public partial struct RC_780ecab424bd911724518df74dd2298a : ITypedRecord<RC_780ecab424bd911724518df74dd2298a> {
internal static readonly GlobalObjectKey IdLogsAccountingSubject = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*tMoOeL0kF5EkUY33TdIpig");

public EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord ssENLogsAccountingSubject;


public static implicit operator EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord( RC_780ecab424bd911724518df74dd2298a r) {
return r.ssENLogsAccountingSubject;
}

public static implicit operator RC_780ecab424bd911724518df74dd2298a (EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord r) {
RC_780ecab424bd911724518df74dd2298a res = new RC_780ecab424bd911724518df74dd2298a ();
res.ssENLogsAccountingSubject = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENLogsAccountingSubject.ChangedAttributes = value;
}
get {
    return ssENLogsAccountingSubject.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_780ecab424bd911724518df74dd2298a() {
OptimizedAttributes = null;
ssENLogsAccountingSubject = new EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENLogsAccountingSubject.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENLogsAccountingSubject.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENLogsAccountingSubject.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENLogsAccountingSubject.Read( r, ref index);
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
public void ReadIM(RC_780ecab424bd911724518df74dd2298a r) {
this = r;
}


public static bool operator == (RC_780ecab424bd911724518df74dd2298a a, RC_780ecab424bd911724518df74dd2298a b) {
if (a.ssENLogsAccountingSubject != b.ssENLogsAccountingSubject) return false;
return true;
}

public static bool operator != (RC_780ecab424bd911724518df74dd2298a a, RC_780ecab424bd911724518df74dd2298a b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_780ecab424bd911724518df74dd2298a)) return false;
return (this == (RC_780ecab424bd911724518df74dd2298a)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENLogsAccountingSubject.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENLogsAccountingSubject.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENLogsAccountingSubject.InternalRecursiveSave();
}


public RC_780ecab424bd911724518df74dd2298a Duplicate() {
RC_780ecab424bd911724518df74dd2298a t;
t.ssENLogsAccountingSubject = (EN_e8a15ee0cbd17f08e6d9bf500f66d770EntityRecord)this.ssENLogsAccountingSubject.Duplicate();
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
if (head == "logsaccountingsubject") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".LogsAccountingSubject")) variable.Value = ssENLogsAccountingSubject; else variable.Optimized = true;
variable.SetFieldName("logsaccountingsubject");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENLogsAccountingSubject.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENLogsAccountingSubject.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdLogsAccountingSubject) {
return ssENLogsAccountingSubject;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdLogsAccountingSubject.Key.AsGuid) {
return ssENLogsAccountingSubject;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENLogsAccountingSubject.FillFromOther((IRecord) other.AttributeGet(IdLogsAccountingSubject));
}
} // RC_780ecab424bd911724518df74dd2298a
/// <summary>
/// RecordList type <code>LogsAccountingSubjectRecordList</code> that represents a record list of
///  <code>LogsAccountingSubject</code>
/// </summary>
public partial class RL_34dd69cc24916a4aeb479486e232e291 : GenericRecordList<RC_780ecab424bd911724518df74dd2298a>, IEnumerable, IEnumerator {

protected override RC_780ecab424bd911724518df74dd2298a GetElementDefaultValue() {
return new RC_780ecab424bd911724518df74dd2298a();
}

public T[] ToArray<T>(Func<RC_780ecab424bd911724518df74dd2298a, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_34dd69cc24916a4aeb479486e232e291 recordList, Func<RC_780ecab424bd911724518df74dd2298a, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_34dd69cc24916a4aeb479486e232e291(RC_780ecab424bd911724518df74dd2298a[] array) {
  RL_34dd69cc24916a4aeb479486e232e291 result = new RL_34dd69cc24916a4aeb479486e232e291();
result.InnerFromArray(array);
    return result;
}

public static RL_34dd69cc24916a4aeb479486e232e291 ToList<T>(T[] array, Func <T, RC_780ecab424bd911724518df74dd2298a> converter) {
  RL_34dd69cc24916a4aeb479486e232e291 result = new RL_34dd69cc24916a4aeb479486e232e291();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_34dd69cc24916a4aeb479486e232e291 FromRestList<T>(RestList<T> restList, Func <T, RC_780ecab424bd911724518df74dd2298a> converter) {
  RL_34dd69cc24916a4aeb479486e232e291 result = new RL_34dd69cc24916a4aeb479486e232e291();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_34dd69cc24916a4aeb479486e232e291() : base() {
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
protected override OSList<RC_780ecab424bd911724518df74dd2298a> NewList() {
return new RL_34dd69cc24916a4aeb479486e232e291();
}


} // RL_34dd69cc24916a4aeb479486e232e291
}

