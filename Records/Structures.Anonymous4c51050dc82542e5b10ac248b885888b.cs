namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (DQVRTCXI5UKxCsJIuIWIiw)
///  <code>RC_5df7bb5aa64fe06d5d087faa4a2fd561</code> that represent
/// s <code>CompanySupplierDetailRecord</code> <p>Description: </p>
/// </summary>
// Name: CompanySupplierDetailRecord
public partial struct RC_5df7bb5aa64fe06d5d087faa4a2fd561 : ITypedRecord<RC_5df7bb5aa64fe06d5d087faa4a2fd561> {
internal static readonly GlobalObjectKey IdCompany = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*bfqhmYH0W+wZCOdwyBtzsQ");
internal static readonly GlobalObjectKey IdSupplierDetail = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*oEdqKrJCTujdtq2dhvCmhA");

public EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord ssENCompany;

public EN_57ee0c02163ab55038103469b2569162EntityRecord ssENSupplierDetail;


public BitArray OptimizedAttributes;

public RC_5df7bb5aa64fe06d5d087faa4a2fd561() {
OptimizedAttributes = null;
ssENCompany = new EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
ssENSupplierDetail = new EN_57ee0c02163ab55038103469b2569162EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(11,false);
    all[1] = new BitArray(26,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENCompany.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENSupplierDetail.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENCompany.OptimizedAttributes = value[0];
    ssENSupplierDetail.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENCompany.OptimizedAttributes;
    all[1] = ssENSupplierDetail.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENCompany.Read( r, ref index);
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
public void ReadIM(RC_5df7bb5aa64fe06d5d087faa4a2fd561 r) {
this = r;
}


public static bool operator == (RC_5df7bb5aa64fe06d5d087faa4a2fd561 a, RC_5df7bb5aa64fe06d5d087faa4a2fd561 b) {
if (a.ssENCompany != b.ssENCompany) return false;
if (a.ssENSupplierDetail != b.ssENSupplierDetail) return false;
return true;
}

public static bool operator != (RC_5df7bb5aa64fe06d5d087faa4a2fd561 a, RC_5df7bb5aa64fe06d5d087faa4a2fd561 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_5df7bb5aa64fe06d5d087faa4a2fd561)) return false;
return (this == (RC_5df7bb5aa64fe06d5d087faa4a2fd561)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENCompany.GetHashCode()
 ^ ssENSupplierDetail.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENCompany.RecursiveReset();
ssENSupplierDetail.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENCompany.InternalRecursiveSave();
ssENSupplierDetail.InternalRecursiveSave();
}


public RC_5df7bb5aa64fe06d5d087faa4a2fd561 Duplicate() {
RC_5df7bb5aa64fe06d5d087faa4a2fd561 t;
t.ssENCompany = (EN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord)this.ssENCompany.Duplicate();
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
if (head == "company") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Company")) variable.Value = ssENCompany; else variable.Optimized = true;
variable.SetFieldName("company");
} else if (head == "supplierdetail") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SupplierDetail")) variable.Value = ssENSupplierDetail; else variable.Optimized = true;
variable.SetFieldName("supplierdetail");
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
if (key == IdCompany) {
return ssENCompany;
}
if (key == IdSupplierDetail) {
return ssENSupplierDetail;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdCompany.Key.AsGuid) {
return ssENCompany;
}
if (attributeKey == IdSupplierDetail.Key.AsGuid) {
return ssENSupplierDetail;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENCompany.FillFromOther((IRecord) other.AttributeGet(IdCompany));
ssENSupplierDetail.FillFromOther((IRecord) other.AttributeGet(IdSupplierDetail));
}
} // RC_5df7bb5aa64fe06d5d087faa4a2fd561
/// <summary>
/// RecordList type <code>CompanySupplierDetailRecordList</code> that represents a record list of
///  <code>Company, SupplierDetail</code>
/// </summary>
public partial class RL_3c0fa01b89994c3e2eaed82b259c3f66 : GenericRecordList<RC_5df7bb5aa64fe06d5d087faa4a2fd561>, IEnumerable, IEnumerator {

protected override RC_5df7bb5aa64fe06d5d087faa4a2fd561 GetElementDefaultValue() {
return new RC_5df7bb5aa64fe06d5d087faa4a2fd561();
}

public T[] ToArray<T>(Func<RC_5df7bb5aa64fe06d5d087faa4a2fd561, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_3c0fa01b89994c3e2eaed82b259c3f66 recordList, Func<RC_5df7bb5aa64fe06d5d087faa4a2fd561, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_3c0fa01b89994c3e2eaed82b259c3f66(RC_5df7bb5aa64fe06d5d087faa4a2fd561[] array) {
  RL_3c0fa01b89994c3e2eaed82b259c3f66 result = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
result.InnerFromArray(array);
    return result;
}

public static RL_3c0fa01b89994c3e2eaed82b259c3f66 ToList<T>(T[] array, Func <T, RC_5df7bb5aa64fe06d5d087faa4a2fd561> converter) {
  RL_3c0fa01b89994c3e2eaed82b259c3f66 result = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_3c0fa01b89994c3e2eaed82b259c3f66 FromRestList<T>(RestList<T> restList, Func <T, RC_5df7bb5aa64fe06d5d087faa4a2fd561> converter) {
  RL_3c0fa01b89994c3e2eaed82b259c3f66 result = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_3c0fa01b89994c3e2eaed82b259c3f66() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(11,false);
def[1] = new BitArray(26,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_5df7bb5aa64fe06d5d087faa4a2fd561> NewList() {
return new RL_3c0fa01b89994c3e2eaed82b259c3f66();
}


} // RL_3c0fa01b89994c3e2eaed82b259c3f66
}

