namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (0ml8XOi1NUeIrA3OIlt6zg)
///  <code>RC_70fa652e74d85e31a0b3b094a20bcd92</code> that represent
/// s <code>InvoiceFileStructRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceFileStructRecord
public partial struct RC_70fa652e74d85e31a0b3b094a20bcd92 : ITypedRecord<RC_70fa652e74d85e31a0b3b094a20bcd92> {
internal static readonly GlobalObjectKey IdInvoiceFileStruct = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*LmX6cNh0MV6gs7CUogvNkg");

public ST_7837994e68174a4794f15e4233b48555Structure ssSTInvoiceFileStruct;


public static implicit operator ST_7837994e68174a4794f15e4233b48555Structure( RC_70fa652e74d85e31a0b3b094a20bcd92 r) {
return r.ssSTInvoiceFileStruct;
}

public static implicit operator RC_70fa652e74d85e31a0b3b094a20bcd92 (ST_7837994e68174a4794f15e4233b48555Structure r) {
RC_70fa652e74d85e31a0b3b094a20bcd92 res = new RC_70fa652e74d85e31a0b3b094a20bcd92 ();
res.ssSTInvoiceFileStruct = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_70fa652e74d85e31a0b3b094a20bcd92() {
OptimizedAttributes = null;
ssSTInvoiceFileStruct = new ST_7837994e68174a4794f15e4233b48555Structure();
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
    ssSTInvoiceFileStruct.OptimizedAttributes = value[0];
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
ssSTInvoiceFileStruct.Read( r, ref index);
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
public void ReadIM(RC_70fa652e74d85e31a0b3b094a20bcd92 r) {
this = r;
}


public static bool operator == (RC_70fa652e74d85e31a0b3b094a20bcd92 a, RC_70fa652e74d85e31a0b3b094a20bcd92 b) {
if (a.ssSTInvoiceFileStruct != b.ssSTInvoiceFileStruct) return false;
return true;
}

public static bool operator != (RC_70fa652e74d85e31a0b3b094a20bcd92 a, RC_70fa652e74d85e31a0b3b094a20bcd92 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_70fa652e74d85e31a0b3b094a20bcd92)) return false;
return (this == (RC_70fa652e74d85e31a0b3b094a20bcd92)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoiceFileStruct.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoiceFileStruct.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoiceFileStruct.InternalRecursiveSave();
}


public RC_70fa652e74d85e31a0b3b094a20bcd92 Duplicate() {
RC_70fa652e74d85e31a0b3b094a20bcd92 t;
t.ssSTInvoiceFileStruct = (ST_7837994e68174a4794f15e4233b48555Structure)this.ssSTInvoiceFileStruct.Duplicate();
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
if (head == "invoicefilestruct") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFileStruct")) variable.Value = ssSTInvoiceFileStruct; else variable.Optimized = true;
variable.SetFieldName("invoicefilestruct");
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
if (key == IdInvoiceFileStruct) {
return ssSTInvoiceFileStruct;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceFileStruct.Key.AsGuid) {
return ssSTInvoiceFileStruct;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoiceFileStruct.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFileStruct));
}
} // RC_70fa652e74d85e31a0b3b094a20bcd92
/// <summary>
/// RecordList type <code>InvoiceFileStructRecordList</code> that represents a record list of
///  <code>InvoiceFileStruct</code>
/// </summary>
public partial class RL_fa7bd88a2d820434ab059161cd28dc3c : GenericRecordList<RC_70fa652e74d85e31a0b3b094a20bcd92>, IEnumerable, IEnumerator {

protected override RC_70fa652e74d85e31a0b3b094a20bcd92 GetElementDefaultValue() {
return new RC_70fa652e74d85e31a0b3b094a20bcd92();
}

public T[] ToArray<T>(Func<RC_70fa652e74d85e31a0b3b094a20bcd92, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_fa7bd88a2d820434ab059161cd28dc3c recordList, Func<RC_70fa652e74d85e31a0b3b094a20bcd92, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_fa7bd88a2d820434ab059161cd28dc3c(RC_70fa652e74d85e31a0b3b094a20bcd92[] array) {
  RL_fa7bd88a2d820434ab059161cd28dc3c result = new RL_fa7bd88a2d820434ab059161cd28dc3c();
result.InnerFromArray(array);
    return result;
}

public static RL_fa7bd88a2d820434ab059161cd28dc3c ToList<T>(T[] array, Func <T, RC_70fa652e74d85e31a0b3b094a20bcd92> converter) {
  RL_fa7bd88a2d820434ab059161cd28dc3c result = new RL_fa7bd88a2d820434ab059161cd28dc3c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_fa7bd88a2d820434ab059161cd28dc3c FromRestList<T>(RestList<T> restList, Func <T, RC_70fa652e74d85e31a0b3b094a20bcd92> converter) {
  RL_fa7bd88a2d820434ab059161cd28dc3c result = new RL_fa7bd88a2d820434ab059161cd28dc3c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_fa7bd88a2d820434ab059161cd28dc3c() : base() {
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
protected override OSList<RC_70fa652e74d85e31a0b3b094a20bcd92> NewList() {
return new RL_fa7bd88a2d820434ab059161cd28dc3c();
}


} // RL_fa7bd88a2d820434ab059161cd28dc3c
}

