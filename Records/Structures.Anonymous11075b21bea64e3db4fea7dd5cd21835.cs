namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (IVsHEaa+PU60_qfdXNIYNQ)
///  <code>RC_d0f36b0aa01c99a6864922a3e47b0bc5</code> that represent
/// s <code>InvoiceInvoiceFileStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceFileStorageRecord
public partial struct RC_d0f36b0aa01c99a6864922a3e47b0bc5 : ITypedRecord<RC_d0f36b0aa01c99a6864922a3e47b0bc5> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_d0f36b0aa01c99a6864922a3e47b0bc5() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceFile.OptimizedAttributes = value[1];
    ssENStorage.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceFile.OptimizedAttributes;
    all[2] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoice.Read( r, ref index);
ssENInvoiceFile.Read( r, ref index);
ssENStorage.Read( r, ref index);
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
public void ReadIM(RC_d0f36b0aa01c99a6864922a3e47b0bc5 r) {
this = r;
}


public static bool operator == (RC_d0f36b0aa01c99a6864922a3e47b0bc5 a, RC_d0f36b0aa01c99a6864922a3e47b0bc5 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_d0f36b0aa01c99a6864922a3e47b0bc5 a, RC_d0f36b0aa01c99a6864922a3e47b0bc5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d0f36b0aa01c99a6864922a3e47b0bc5)) return false;
return (this == (RC_d0f36b0aa01c99a6864922a3e47b0bc5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_d0f36b0aa01c99a6864922a3e47b0bc5 Duplicate() {
RC_d0f36b0aa01c99a6864922a3e47b0bc5 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
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
if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
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
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_d0f36b0aa01c99a6864922a3e47b0bc5
/// <summary>
/// RecordList type <code>InvoiceInvoiceFileStorageRecordList</code> that represents a record list of
///  <code>Invoice, InvoiceFile, Storage</code>
/// </summary>
public partial class RL_9d61cc7501a4784be77b036c540a3e93 : GenericRecordList<RC_d0f36b0aa01c99a6864922a3e47b0bc5>, IEnumerable, IEnumerator {

protected override RC_d0f36b0aa01c99a6864922a3e47b0bc5 GetElementDefaultValue() {
return new RC_d0f36b0aa01c99a6864922a3e47b0bc5();
}

public T[] ToArray<T>(Func<RC_d0f36b0aa01c99a6864922a3e47b0bc5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9d61cc7501a4784be77b036c540a3e93 recordList, Func<RC_d0f36b0aa01c99a6864922a3e47b0bc5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9d61cc7501a4784be77b036c540a3e93(RC_d0f36b0aa01c99a6864922a3e47b0bc5[] array) {
  RL_9d61cc7501a4784be77b036c540a3e93 result = new RL_9d61cc7501a4784be77b036c540a3e93();
result.InnerFromArray(array);
    return result;
}

public static RL_9d61cc7501a4784be77b036c540a3e93 ToList<T>(T[] array, Func <T, RC_d0f36b0aa01c99a6864922a3e47b0bc5> converter) {
  RL_9d61cc7501a4784be77b036c540a3e93 result = new RL_9d61cc7501a4784be77b036c540a3e93();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9d61cc7501a4784be77b036c540a3e93 FromRestList<T>(RestList<T> restList, Func <T, RC_d0f36b0aa01c99a6864922a3e47b0bc5> converter) {
  RL_9d61cc7501a4784be77b036c540a3e93 result = new RL_9d61cc7501a4784be77b036c540a3e93();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9d61cc7501a4784be77b036c540a3e93() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(24,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_d0f36b0aa01c99a6864922a3e47b0bc5> NewList() {
return new RL_9d61cc7501a4784be77b036c540a3e93();
}


} // RL_9d61cc7501a4784be77b036c540a3e93
}

