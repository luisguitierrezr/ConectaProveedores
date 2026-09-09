namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (naAo393GF0C9vYXuo1Z+UQ)
///  <code>RC_2948f028a510ee594d050df56aefa0c8</code> that represent
/// s
///  <code>InvoiceInvoiceFileRequisitionInvoiceAccountingInvoiceExtendedStorageSupplierRegionRecord</cod
/// e> <p>Description: </p>
/// </summary>
// Name: InvoiceInvoiceFileRequisitionInvoiceAccountingInvoiceExtendedStorageSupplierRegionRecord
public partial struct RC_2948f028a510ee594d050df56aefa0c8 : ITypedRecord<RC_2948f028a510ee594d050df56aefa0c8> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdInvoiceAccounting = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*PqiYw9GniAlua+aT9tB4Zw");
internal static readonly GlobalObjectKey IdInvoiceExtended = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*BfHj+9QKT_Og4KFfiKVocw");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdRegion = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*w1243kBmkvqNrl3ySTBl0A");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord ssENInvoiceAccounting;

public EN_f81a3d226103fd013068b8763798067aEntityRecord ssENInvoiceExtended;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_31f501c551d210017fcb34b5237e3390EntityRecord ssENRegion;


public BitArray OptimizedAttributes;

public RC_2948f028a510ee594d050df56aefa0c8() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENInvoiceAccounting = new EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
ssENInvoiceExtended = new EN_f81a3d226103fd013068b8763798067aEntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENRegion = new EN_31f501c551d210017fcb34b5237e3390EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[8];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(58,false);
    all[3] = new BitArray(21,false);
    all[4] = new BitArray(19,false);
    all[5] = new BitArray(20,false);
    all[6] = new BitArray(28,false);
    all[7] = new BitArray(13,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENInvoiceAccounting.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENInvoiceExtended.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENRegion.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENInvoiceFile.OptimizedAttributes = value[1];
    ssENRequisition.OptimizedAttributes = value[2];
    ssENInvoiceAccounting.OptimizedAttributes = value[3];
    ssENInvoiceExtended.OptimizedAttributes = value[4];
    ssENStorage.OptimizedAttributes = value[5];
    ssENSupplier.OptimizedAttributes = value[6];
    ssENRegion.OptimizedAttributes = value[7];
    }
}
get{
    BitArray[] all = new BitArray[8];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENInvoiceFile.OptimizedAttributes;
    all[2] = ssENRequisition.OptimizedAttributes;
    all[3] = ssENInvoiceAccounting.OptimizedAttributes;
    all[4] = ssENInvoiceExtended.OptimizedAttributes;
    all[5] = ssENStorage.OptimizedAttributes;
    all[6] = ssENSupplier.OptimizedAttributes;
    all[7] = ssENRegion.OptimizedAttributes;
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
ssENRequisition.Read( r, ref index);
ssENInvoiceAccounting.Read( r, ref index);
ssENInvoiceExtended.Read( r, ref index);
ssENStorage.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENRegion.Read( r, ref index);
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
public void ReadIM(RC_2948f028a510ee594d050df56aefa0c8 r) {
this = r;
}


public static bool operator == (RC_2948f028a510ee594d050df56aefa0c8 a, RC_2948f028a510ee594d050df56aefa0c8 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENInvoiceAccounting != b.ssENInvoiceAccounting) return false;
if (a.ssENInvoiceExtended != b.ssENInvoiceExtended) return false;
if (a.ssENStorage != b.ssENStorage) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENRegion != b.ssENRegion) return false;
return true;
}

public static bool operator != (RC_2948f028a510ee594d050df56aefa0c8 a, RC_2948f028a510ee594d050df56aefa0c8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_2948f028a510ee594d050df56aefa0c8)) return false;
return (this == (RC_2948f028a510ee594d050df56aefa0c8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENInvoiceAccounting.GetHashCode()
 ^ ssENInvoiceExtended.GetHashCode()
 ^ ssENStorage.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENRegion.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENInvoiceAccounting.RecursiveReset();
ssENInvoiceExtended.RecursiveReset();
ssENStorage.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENRegion.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENInvoiceAccounting.InternalRecursiveSave();
ssENInvoiceExtended.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENRegion.InternalRecursiveSave();
}


public RC_2948f028a510ee594d050df56aefa0c8 Duplicate() {
RC_2948f028a510ee594d050df56aefa0c8 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENInvoiceAccounting = (EN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord)this.ssENInvoiceAccounting.Duplicate();
t.ssENInvoiceExtended = (EN_f81a3d226103fd013068b8763798067aEntityRecord)this.ssENInvoiceExtended.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENRegion = (EN_31f501c551d210017fcb34b5237e3390EntityRecord)this.ssENRegion.Duplicate();
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
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "invoiceaccounting") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceAccounting")) variable.Value = ssENInvoiceAccounting; else variable.Optimized = true;
variable.SetFieldName("invoiceaccounting");
} else if (head == "invoiceextended") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceExtended")) variable.Value = ssENInvoiceExtended; else variable.Optimized = true;
variable.SetFieldName("invoiceextended");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "region") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Region")) variable.Value = ssENRegion; else variable.Optimized = true;
variable.SetFieldName("region");
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
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdInvoiceAccounting) {
return ssENInvoiceAccounting;
}
if (key == IdInvoiceExtended) {
return ssENInvoiceExtended;
}
if (key == IdStorage) {
return ssENStorage;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdRegion) {
return ssENRegion;
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
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdInvoiceAccounting.Key.AsGuid) {
return ssENInvoiceAccounting;
}
if (attributeKey == IdInvoiceExtended.Key.AsGuid) {
return ssENInvoiceExtended;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdRegion.Key.AsGuid) {
return ssENRegion;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENInvoiceAccounting.FillFromOther((IRecord) other.AttributeGet(IdInvoiceAccounting));
ssENInvoiceExtended.FillFromOther((IRecord) other.AttributeGet(IdInvoiceExtended));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENRegion.FillFromOther((IRecord) other.AttributeGet(IdRegion));
}
} // RC_2948f028a510ee594d050df56aefa0c8
/// <summary>
/// RecordList type
///  <code>InvoiceInvoiceFileRequisitionInvoiceAccountingInvoiceExtendedStorageSupplierRegionRecordList<
/// /code> that represents a record list of <code>Invoice, InvoiceFile, Requisition, InvoiceAccounting,
///  InvoiceExtended, Storage, Supplier, Region</code>
/// </summary>
public partial class RL_1d4c61caa98ecb2b0573c3d151f4f72a : GenericRecordList<RC_2948f028a510ee594d050df56aefa0c8>, IEnumerable, IEnumerator {

protected override RC_2948f028a510ee594d050df56aefa0c8 GetElementDefaultValue() {
return new RC_2948f028a510ee594d050df56aefa0c8();
}

public T[] ToArray<T>(Func<RC_2948f028a510ee594d050df56aefa0c8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1d4c61caa98ecb2b0573c3d151f4f72a recordList, Func<RC_2948f028a510ee594d050df56aefa0c8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1d4c61caa98ecb2b0573c3d151f4f72a(RC_2948f028a510ee594d050df56aefa0c8[] array) {
  RL_1d4c61caa98ecb2b0573c3d151f4f72a result = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
result.InnerFromArray(array);
    return result;
}

public static RL_1d4c61caa98ecb2b0573c3d151f4f72a ToList<T>(T[] array, Func <T, RC_2948f028a510ee594d050df56aefa0c8> converter) {
  RL_1d4c61caa98ecb2b0573c3d151f4f72a result = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1d4c61caa98ecb2b0573c3d151f4f72a FromRestList<T>(RestList<T> restList, Func <T, RC_2948f028a510ee594d050df56aefa0c8> converter) {
  RL_1d4c61caa98ecb2b0573c3d151f4f72a result = new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1d4c61caa98ecb2b0573c3d151f4f72a() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[8];
def[0] = new BitArray(24,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(58,false);
def[3] = new BitArray(21,false);
def[4] = new BitArray(19,false);
def[5] = new BitArray(20,false);
def[6] = new BitArray(28,false);
def[7] = new BitArray(13,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_2948f028a510ee594d050df56aefa0c8> NewList() {
return new RL_1d4c61caa98ecb2b0573c3d151f4f72a();
}


} // RL_1d4c61caa98ecb2b0573c3d151f4f72a
}

