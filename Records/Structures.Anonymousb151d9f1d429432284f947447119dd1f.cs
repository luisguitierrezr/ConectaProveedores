namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (8dlRsSnUIkOE+UdEcRndHw)
///  <code>RC_34acf11553964937c377a82c97a2edf5</code> that represents <code>SpecialApprovalRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SpecialApprovalRecord
public partial struct RC_34acf11553964937c377a82c97a2edf5 : ITypedRecord<RC_34acf11553964937c377a82c97a2edf5> {
internal static readonly GlobalObjectKey IdSpecialApproval = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*FfGsNJZTN0nDd6gsl6Lt9Q");

public EN_269041044ca0bb6901788ecb5d297c5eEntityRecord ssENSpecialApproval;


public static implicit operator EN_269041044ca0bb6901788ecb5d297c5eEntityRecord( RC_34acf11553964937c377a82c97a2edf5 r) {
return r.ssENSpecialApproval;
}

public static implicit operator RC_34acf11553964937c377a82c97a2edf5 (EN_269041044ca0bb6901788ecb5d297c5eEntityRecord r) {
RC_34acf11553964937c377a82c97a2edf5 res = new RC_34acf11553964937c377a82c97a2edf5 ();
res.ssENSpecialApproval = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSpecialApproval.ChangedAttributes = value;
}
get {
    return ssENSpecialApproval.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_34acf11553964937c377a82c97a2edf5() {
OptimizedAttributes = null;
ssENSpecialApproval = new EN_269041044ca0bb6901788ecb5d297c5eEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(4,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSpecialApproval.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSpecialApproval.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSpecialApproval.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSpecialApproval.Read( r, ref index);
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
public void ReadIM(RC_34acf11553964937c377a82c97a2edf5 r) {
this = r;
}


public static bool operator == (RC_34acf11553964937c377a82c97a2edf5 a, RC_34acf11553964937c377a82c97a2edf5 b) {
if (a.ssENSpecialApproval != b.ssENSpecialApproval) return false;
return true;
}

public static bool operator != (RC_34acf11553964937c377a82c97a2edf5 a, RC_34acf11553964937c377a82c97a2edf5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_34acf11553964937c377a82c97a2edf5)) return false;
return (this == (RC_34acf11553964937c377a82c97a2edf5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSpecialApproval.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSpecialApproval.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSpecialApproval.InternalRecursiveSave();
}


public RC_34acf11553964937c377a82c97a2edf5 Duplicate() {
RC_34acf11553964937c377a82c97a2edf5 t;
t.ssENSpecialApproval = (EN_269041044ca0bb6901788ecb5d297c5eEntityRecord)this.ssENSpecialApproval.Duplicate();
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
if (head == "specialapproval") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SpecialApproval")) variable.Value = ssENSpecialApproval; else variable.Optimized = true;
variable.SetFieldName("specialapproval");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialApproval.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSpecialApproval.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSpecialApproval) {
return ssENSpecialApproval;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSpecialApproval.Key.AsGuid) {
return ssENSpecialApproval;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSpecialApproval.FillFromOther((IRecord) other.AttributeGet(IdSpecialApproval));
}
} // RC_34acf11553964937c377a82c97a2edf5
/// <summary>
/// RecordList type <code>SpecialApprovalRecordList</code> that represents a record list of
///  <code>SpecialApproval</code>
/// </summary>
public partial class RL_0204de281fa136fb826199f876159fe4 : GenericRecordList<RC_34acf11553964937c377a82c97a2edf5>, IEnumerable, IEnumerator {

protected override RC_34acf11553964937c377a82c97a2edf5 GetElementDefaultValue() {
return new RC_34acf11553964937c377a82c97a2edf5();
}

public T[] ToArray<T>(Func<RC_34acf11553964937c377a82c97a2edf5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_0204de281fa136fb826199f876159fe4 recordList, Func<RC_34acf11553964937c377a82c97a2edf5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_0204de281fa136fb826199f876159fe4(RC_34acf11553964937c377a82c97a2edf5[] array) {
  RL_0204de281fa136fb826199f876159fe4 result = new RL_0204de281fa136fb826199f876159fe4();
result.InnerFromArray(array);
    return result;
}

public static RL_0204de281fa136fb826199f876159fe4 ToList<T>(T[] array, Func <T, RC_34acf11553964937c377a82c97a2edf5> converter) {
  RL_0204de281fa136fb826199f876159fe4 result = new RL_0204de281fa136fb826199f876159fe4();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_0204de281fa136fb826199f876159fe4 FromRestList<T>(RestList<T> restList, Func <T, RC_34acf11553964937c377a82c97a2edf5> converter) {
  RL_0204de281fa136fb826199f876159fe4 result = new RL_0204de281fa136fb826199f876159fe4();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_0204de281fa136fb826199f876159fe4() : base() {
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
protected override OSList<RC_34acf11553964937c377a82c97a2edf5> NewList() {
return new RL_0204de281fa136fb826199f876159fe4();
}


} // RL_0204de281fa136fb826199f876159fe4
}

