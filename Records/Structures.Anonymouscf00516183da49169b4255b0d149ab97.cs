namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (YVEAz9qDFkmbQlWw0Umrlw)
///  <code>RC_6a021efe2f8dc2f10ec54998b1f4e9f9</code> that represents <code>PaymentDateRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: PaymentDateRecord
public partial struct RC_6a021efe2f8dc2f10ec54998b1f4e9f9 : ITypedRecord<RC_6a021efe2f8dc2f10ec54998b1f4e9f9> {
internal static readonly GlobalObjectKey IdPaymentDate = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*_h4Cao0v8cIOxUmYsfTp+Q");

public DateTime ssPaymentDate;


public BitArray OptimizedAttributes;

public RC_6a021efe2f8dc2f10ec54998b1f4e9f9() {
OptimizedAttributes = null;
ssPaymentDate = new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc);
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[0];
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    }else{
    }
}
get{
    BitArray[] all = new BitArray[0];
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssPaymentDate = r.ReadDate(index++, "PaymentDateRecord.PaymentDate", new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
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
public void ReadIM(RC_6a021efe2f8dc2f10ec54998b1f4e9f9 r) {
this = r;
}


public static bool operator == (RC_6a021efe2f8dc2f10ec54998b1f4e9f9 a, RC_6a021efe2f8dc2f10ec54998b1f4e9f9 b) {
if (a.ssPaymentDate != b.ssPaymentDate) return false;
return true;
}

public static bool operator != (RC_6a021efe2f8dc2f10ec54998b1f4e9f9 a, RC_6a021efe2f8dc2f10ec54998b1f4e9f9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6a021efe2f8dc2f10ec54998b1f4e9f9)) return false;
return (this == (RC_6a021efe2f8dc2f10ec54998b1f4e9f9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssPaymentDate.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
}

public void InternalRecursiveSave() {
}


public RC_6a021efe2f8dc2f10ec54998b1f4e9f9 Duplicate() {
RC_6a021efe2f8dc2f10ec54998b1f4e9f9 t;
t.ssPaymentDate = this.ssPaymentDate;
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
if (head == "paymentdate") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".PaymentDate")) variable.Value = ssPaymentDate; else variable.Optimized = true;
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
if (key == IdPaymentDate) {
return ssPaymentDate;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdPaymentDate.Key.AsGuid) {
return ssPaymentDate;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssPaymentDate = (DateTime) other.AttributeGet(IdPaymentDate);
}
} // RC_6a021efe2f8dc2f10ec54998b1f4e9f9
/// <summary>
/// RecordList type <code>PaymentDateRecordList</code> that represents a record list of
///  <code>Date</code>
/// </summary>
public partial class RL_ea661a757b018679fb7e2281b3d5eb8c : GenericRecordList<RC_6a021efe2f8dc2f10ec54998b1f4e9f9>, IEnumerable, IEnumerator {

protected override RC_6a021efe2f8dc2f10ec54998b1f4e9f9 GetElementDefaultValue() {
return new RC_6a021efe2f8dc2f10ec54998b1f4e9f9();
}

public T[] ToArray<T>(Func<RC_6a021efe2f8dc2f10ec54998b1f4e9f9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_ea661a757b018679fb7e2281b3d5eb8c recordList, Func<RC_6a021efe2f8dc2f10ec54998b1f4e9f9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_ea661a757b018679fb7e2281b3d5eb8c(RC_6a021efe2f8dc2f10ec54998b1f4e9f9[] array) {
  RL_ea661a757b018679fb7e2281b3d5eb8c result = new RL_ea661a757b018679fb7e2281b3d5eb8c();
result.InnerFromArray(array);
    return result;
}

public static RL_ea661a757b018679fb7e2281b3d5eb8c ToList<T>(T[] array, Func <T, RC_6a021efe2f8dc2f10ec54998b1f4e9f9> converter) {
  RL_ea661a757b018679fb7e2281b3d5eb8c result = new RL_ea661a757b018679fb7e2281b3d5eb8c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_ea661a757b018679fb7e2281b3d5eb8c FromRestList<T>(RestList<T> restList, Func <T, RC_6a021efe2f8dc2f10ec54998b1f4e9f9> converter) {
  RL_ea661a757b018679fb7e2281b3d5eb8c result = new RL_ea661a757b018679fb7e2281b3d5eb8c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_ea661a757b018679fb7e2281b3d5eb8c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[0];
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6a021efe2f8dc2f10ec54998b1f4e9f9> NewList() {
return new RL_ea661a757b018679fb7e2281b3d5eb8c();
}


} // RL_ea661a757b018679fb7e2281b3d5eb8c
}

