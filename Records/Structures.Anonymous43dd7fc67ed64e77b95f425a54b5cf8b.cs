namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (xn_dQ9Z+d065X0JaVLXPiw)
///  <code>RC_6a167614a0071e1e1c2b280f79f64190</code> that represent
/// s
///  <code>InvoiceFolioInvoiceFileRequisitionOrderMainStorageSupplierSupplier_2Supplier_3RegionIdRecord<
/// /code> <p>Description: </p>
/// </summary>
// Name: InvoiceFolioInvoiceFileRequisitionOrderMainStorageSupplierSupplier_2Supplier_3RegionIdRecord
public partial struct RC_6a167614a0071e1e1c2b280f79f64190 : ITypedRecord<RC_6a167614a0071e1e1c2b280f79f64190> {
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdRequisition = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*T3SBu1iqc67nzY23TLMhVQ");
internal static readonly GlobalObjectKey IdOrderMain = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*SNWDFQxCHyP7k0WDEoAERg");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");
internal static readonly GlobalObjectKey IdSupplier_2 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dKVgXXVD5QDsAPy_pPY4+g");
internal static readonly GlobalObjectKey IdSupplier_3 = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*F0ax+4bbi+bJX5ijmWzaWQ");
internal static readonly GlobalObjectKey IdRegionId = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nkxR7nUXmQLbRVrKGXTzig");

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public EN_98680591dcf3728e0877a90eb5e1e552EntityRecord ssENRequisition;

public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord ssENOrderMain;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier_2;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier_3;

public long ssRegionId;


public BitArray OptimizedAttributes;

public RC_6a167614a0071e1e1c2b280f79f64190() {
OptimizedAttributes = null;
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssENRequisition = new EN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
ssENOrderMain = new EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENSupplier_2 = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssENSupplier_3 = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
ssRegionId = 0L;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[9];
    all[0] = new BitArray(24,false);
    all[1] = new BitArray(20,false);
    all[2] = new BitArray(8,false);
    all[3] = new BitArray(58,false);
    all[4] = new BitArray(29,false);
    all[5] = new BitArray(20,false);
    all[6] = new BitArray(28,false);
    all[7] = new BitArray(28,false);
    all[8] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENRequisition.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENOrderMain.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[5];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[6];
    ssENSupplier_2.OptimizedAttributes = GetDefaultOptimizedValues()[7];
    ssENSupplier_3.OptimizedAttributes = GetDefaultOptimizedValues()[8];
    }else{
    ssENInvoice.OptimizedAttributes = value[0];
    ssENFolio.OptimizedAttributes = value[1];
    ssENInvoiceFile.OptimizedAttributes = value[2];
    ssENRequisition.OptimizedAttributes = value[3];
    ssENOrderMain.OptimizedAttributes = value[4];
    ssENStorage.OptimizedAttributes = value[5];
    ssENSupplier.OptimizedAttributes = value[6];
    ssENSupplier_2.OptimizedAttributes = value[7];
    ssENSupplier_3.OptimizedAttributes = value[8];
    }
}
get{
    BitArray[] all = new BitArray[9];
    all[0] = ssENInvoice.OptimizedAttributes;
    all[1] = ssENFolio.OptimizedAttributes;
    all[2] = ssENInvoiceFile.OptimizedAttributes;
    all[3] = ssENRequisition.OptimizedAttributes;
    all[4] = ssENOrderMain.OptimizedAttributes;
    all[5] = ssENStorage.OptimizedAttributes;
    all[6] = ssENSupplier.OptimizedAttributes;
    all[7] = ssENSupplier_2.OptimizedAttributes;
    all[8] = ssENSupplier_3.OptimizedAttributes;
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
ssENFolio.Read( r, ref index);
ssENInvoiceFile.Read( r, ref index);
ssENRequisition.Read( r, ref index);
ssENOrderMain.Read( r, ref index);
ssENStorage.Read( r, ref index);
ssENSupplier.Read( r, ref index);
ssENSupplier_2.Read( r, ref index);
ssENSupplier_3.Read( r, ref index);
ssRegionId = r.ReadEntityReferenceLongInteger(index++, "InvoiceFolioInvoiceFileRequisitionOrderMainStorageSupplierSupplier_2Supplier_3RegionIdRecord.RegionId", 0L);
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
public void ReadIM(RC_6a167614a0071e1e1c2b280f79f64190 r) {
this = r;
}


public static bool operator == (RC_6a167614a0071e1e1c2b280f79f64190 a, RC_6a167614a0071e1e1c2b280f79f64190 b) {
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssENRequisition != b.ssENRequisition) return false;
if (a.ssENOrderMain != b.ssENOrderMain) return false;
if (a.ssENStorage != b.ssENStorage) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
if (a.ssENSupplier_2 != b.ssENSupplier_2) return false;
if (a.ssENSupplier_3 != b.ssENSupplier_3) return false;
if (a.ssRegionId != b.ssRegionId) return false;
return true;
}

public static bool operator != (RC_6a167614a0071e1e1c2b280f79f64190 a, RC_6a167614a0071e1e1c2b280f79f64190 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_6a167614a0071e1e1c2b280f79f64190)) return false;
return (this == (RC_6a167614a0071e1e1c2b280f79f64190)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssENRequisition.GetHashCode()
 ^ ssENOrderMain.GetHashCode()
 ^ ssENStorage.GetHashCode()
 ^ ssENSupplier.GetHashCode()
 ^ ssENSupplier_2.GetHashCode()
 ^ ssENSupplier_3.GetHashCode()
 ^ ssRegionId.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
ssENRequisition.RecursiveReset();
ssENOrderMain.RecursiveReset();
ssENStorage.RecursiveReset();
ssENSupplier.RecursiveReset();
ssENSupplier_2.RecursiveReset();
ssENSupplier_3.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
ssENRequisition.InternalRecursiveSave();
ssENOrderMain.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
ssENSupplier_2.InternalRecursiveSave();
ssENSupplier_3.InternalRecursiveSave();
}


public RC_6a167614a0071e1e1c2b280f79f64190 Duplicate() {
RC_6a167614a0071e1e1c2b280f79f64190 t;
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
t.ssENRequisition = (EN_98680591dcf3728e0877a90eb5e1e552EntityRecord)this.ssENRequisition.Duplicate();
t.ssENOrderMain = (EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord)this.ssENOrderMain.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
t.ssENSupplier_2 = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier_2.Duplicate();
t.ssENSupplier_3 = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier_3.Duplicate();
t.ssRegionId = this.ssRegionId;
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
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
} else if (head == "requisition") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Requisition")) variable.Value = ssENRequisition; else variable.Optimized = true;
variable.SetFieldName("requisition");
} else if (head == "ordermain") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".OrderMain")) variable.Value = ssENOrderMain; else variable.Optimized = true;
variable.SetFieldName("ordermain");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
} else if (head == "supplier_2") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier_2")) variable.Value = ssENSupplier_2; else variable.Optimized = true;
variable.SetFieldName("supplier_2");
} else if (head == "supplier_3") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier_3")) variable.Value = ssENSupplier_3; else variable.Optimized = true;
variable.SetFieldName("supplier_3");
} else if (head == "regionid") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".RegionId")) variable.Value = ssRegionId; else variable.Optimized = true;
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
}
if (key == IdRequisition) {
return ssENRequisition;
}
if (key == IdOrderMain) {
return ssENOrderMain;
}
if (key == IdStorage) {
return ssENStorage;
}
if (key == IdSupplier) {
return ssENSupplier;
}
if (key == IdSupplier_2) {
return ssENSupplier_2;
}
if (key == IdSupplier_3) {
return ssENSupplier_3;
}
if (key == IdRegionId) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
if (attributeKey == IdRequisition.Key.AsGuid) {
return ssENRequisition;
}
if (attributeKey == IdOrderMain.Key.AsGuid) {
return ssENOrderMain;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
if (attributeKey == IdSupplier_2.Key.AsGuid) {
return ssENSupplier_2;
}
if (attributeKey == IdSupplier_3.Key.AsGuid) {
return ssENSupplier_3;
}
if (attributeKey == IdRegionId.Key.AsGuid) {
return ssRegionId;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssENRequisition.FillFromOther((IRecord) other.AttributeGet(IdRequisition));
ssENOrderMain.FillFromOther((IRecord) other.AttributeGet(IdOrderMain));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
ssENSupplier_2.FillFromOther((IRecord) other.AttributeGet(IdSupplier_2));
ssENSupplier_3.FillFromOther((IRecord) other.AttributeGet(IdSupplier_3));
ssRegionId = (long) other.AttributeGet(IdRegionId);
}
} // RC_6a167614a0071e1e1c2b280f79f64190
/// <summary>
/// RecordList type
///  <code>InvoiceFolioInvoiceFileRequisitionOrderMainStorageSupplierSupplier_2Supplier_3RegionIdRecordL
/// ist</code> that represents a record list of <code>Invoice, Folio, InvoiceFile, Requisition,
///  OrderMain, Storage, Supplier, Supplier, Supplier, RegionIdentifier</code>
/// </summary>
public partial class RL_26f7eba5ac045368b1e866dc619ecc4d : GenericRecordList<RC_6a167614a0071e1e1c2b280f79f64190>, IEnumerable, IEnumerator {

protected override RC_6a167614a0071e1e1c2b280f79f64190 GetElementDefaultValue() {
return new RC_6a167614a0071e1e1c2b280f79f64190();
}

public T[] ToArray<T>(Func<RC_6a167614a0071e1e1c2b280f79f64190, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_26f7eba5ac045368b1e866dc619ecc4d recordList, Func<RC_6a167614a0071e1e1c2b280f79f64190, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_26f7eba5ac045368b1e866dc619ecc4d(RC_6a167614a0071e1e1c2b280f79f64190[] array) {
  RL_26f7eba5ac045368b1e866dc619ecc4d result = new RL_26f7eba5ac045368b1e866dc619ecc4d();
result.InnerFromArray(array);
    return result;
}

public static RL_26f7eba5ac045368b1e866dc619ecc4d ToList<T>(T[] array, Func <T, RC_6a167614a0071e1e1c2b280f79f64190> converter) {
  RL_26f7eba5ac045368b1e866dc619ecc4d result = new RL_26f7eba5ac045368b1e866dc619ecc4d();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_26f7eba5ac045368b1e866dc619ecc4d FromRestList<T>(RestList<T> restList, Func <T, RC_6a167614a0071e1e1c2b280f79f64190> converter) {
  RL_26f7eba5ac045368b1e866dc619ecc4d result = new RL_26f7eba5ac045368b1e866dc619ecc4d();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_26f7eba5ac045368b1e866dc619ecc4d() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[9];
def[0] = new BitArray(24,false);
def[1] = new BitArray(20,false);
def[2] = new BitArray(8,false);
def[3] = new BitArray(58,false);
def[4] = new BitArray(29,false);
def[5] = new BitArray(20,false);
def[6] = new BitArray(28,false);
def[7] = new BitArray(28,false);
def[8] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_6a167614a0071e1e1c2b280f79f64190> NewList() {
return new RL_26f7eba5ac045368b1e866dc619ecc4d();
}


} // RL_26f7eba5ac045368b1e866dc619ecc4d
}

