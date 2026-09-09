namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Jl29Pkb0+EOv6ghl6P40Ug)
///  <code>RC_2a6a47a042b2e84eddb6ad9d86f0a684</code> that represents <code>SupplierDetailRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SupplierDetailRecord
public partial struct RC_2a6a47a042b2e84eddb6ad9d86f0a684 : ITypedRecord<RC_2a6a47a042b2e84eddb6ad9d86f0a684> {
internal static readonly GlobalObjectKey IdSupplierDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oEdqKrJCTujdtq2dhvCmhA");

public EN_57ee0c02163ab55038103469b2569162EntityRecord ssENSupplierDetail;


public static implicit operator EN_57ee0c02163ab55038103469b2569162EntityRecord( RC_2a6a47a042b2e84eddb6ad9d86f0a684 r) {
return r.ssENSupplierDetail;
}

public static implicit operator RC_2a6a47a042b2e84eddb6ad9d86f0a684 (EN_57ee0c02163ab55038103469b2569162EntityRecord r) {
RC_2a6a47a042b2e84eddb6ad9d86f0a684 res = new RC_2a6a47a042b2e84eddb6ad9d86f0a684 ();
res.ssENSupplierDetail = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENSupplierDetail.ChangedAttributes = value;
}
get {
    return ssENSupplierDetail.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_2a6a47a042b2e84eddb6ad9d86f0a684() {
OptimizedAttributes = null;
ssENSupplierDetail = new EN_57ee0c02163ab55038103469b2569162EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(26,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENSupplierDetail.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENSupplierDetail.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENSupplierDetail.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENSupplierDetail.Read( r, ref index);
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
public void ReadIM(RC_2a6a47a042b2e84eddb6ad9d86f0a684 r) {
this = r;
}


public static bool operator == (RC_2a6a47a042b2e84eddb6ad9d86f0a684 a, RC_2a6a47a042b2e84eddb6ad9d86f0a684 b) {
if (a.ssENSupplierDetail != b.ssENSupplierDetail) return false;
return true;
}

public static bool operator != (RC_2a6a47a042b2e84eddb6ad9d86f0a684 a, RC_2a6a47a042b2e84eddb6ad9d86f0a684 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2a6a47a042b2e84eddb6ad9d86f0a684)) return false;
return (this == (RC_2a6a47a042b2e84eddb6ad9d86f0a684)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENSupplierDetail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENSupplierDetail.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENSupplierDetail.InternalRecursiveSave();
}


public RC_2a6a47a042b2e84eddb6ad9d86f0a684 Duplicate() {
RC_2a6a47a042b2e84eddb6ad9d86f0a684 t;
t.ssENSupplierDetail = (EN_57ee0c02163ab55038103469b2569162EntityRecord)this.ssENSupplierDetail.Duplicate();
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
if (head == "supplierdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierDetail")) variable.Value = ssENSupplierDetail; else variable.Optimized = true;
variable.SetFieldName("supplierdetail");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENSupplierDetail.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENSupplierDetail.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdSupplierDetail) {
return ssENSupplierDetail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSupplierDetail.Key.AsGuid) {
return ssENSupplierDetail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENSupplierDetail.FillFromOther((IRecord) other.AttributeGet(IdSupplierDetail));
}
} // RC_2a6a47a042b2e84eddb6ad9d86f0a684
/// <summary>
/// RecordList type <code>SupplierDetailRecordList</code> that represents a record list of
///  <code>SupplierDetail</code>
/// </summary>
public partial class RL_10b798eceef0c61e2eb85d7fd35e40d6 : GenericRecordList<RC_2a6a47a042b2e84eddb6ad9d86f0a684>, IEnumerable, IEnumerator {

protected override RC_2a6a47a042b2e84eddb6ad9d86f0a684 GetElementDefaultValue() {
return new RC_2a6a47a042b2e84eddb6ad9d86f0a684();
}

public T[] ToArray<T>(Func<RC_2a6a47a042b2e84eddb6ad9d86f0a684, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_10b798eceef0c61e2eb85d7fd35e40d6 recordList, Func<RC_2a6a47a042b2e84eddb6ad9d86f0a684, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_10b798eceef0c61e2eb85d7fd35e40d6(RC_2a6a47a042b2e84eddb6ad9d86f0a684[] array) {
  RL_10b798eceef0c61e2eb85d7fd35e40d6 result = new RL_10b798eceef0c61e2eb85d7fd35e40d6();
result.InnerFromArray(array);
    return result;
}

public static RL_10b798eceef0c61e2eb85d7fd35e40d6 ToList<T>(T[] array, Func <T, RC_2a6a47a042b2e84eddb6ad9d86f0a684> converter) {
  RL_10b798eceef0c61e2eb85d7fd35e40d6 result = new RL_10b798eceef0c61e2eb85d7fd35e40d6();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_10b798eceef0c61e2eb85d7fd35e40d6 FromRestList<T>(RestList<T> restList, Func <T, RC_2a6a47a042b2e84eddb6ad9d86f0a684> converter) {
  RL_10b798eceef0c61e2eb85d7fd35e40d6 result = new RL_10b798eceef0c61e2eb85d7fd35e40d6();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_10b798eceef0c61e2eb85d7fd35e40d6() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(26,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2a6a47a042b2e84eddb6ad9d86f0a684> NewList() {
return new RL_10b798eceef0c61e2eb85d7fd35e40d6();
}


} // RL_10b798eceef0c61e2eb85d7fd35e40d6
}

