namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (fILNvEs900ePthQpN2GIag)
///  <code>RC_c6c14818b27b1ae2048888ac314317c1</code> that represent
/// s <code>FolioFolioFilesStorageSupplierRecord</code> <p>Description: </p>
/// </summary>
// Name: FolioFolioFilesStorageSupplierRecord
public partial struct RC_c6c14818b27b1ae2048888ac314317c1 : ITypedRecord<RC_c6c14818b27b1ae2048888ac314317c1> {
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qLf9KPiu3JGSHF_jQ5OlaQ");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");
internal static readonly GlobalObjectKey IdSupplier = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*dOw0SWrcY4B7hMCYX1sSzg");

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord ssENFolioFiles;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;

public EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord ssENSupplier;


public BitArray OptimizedAttributes;

public RC_c6c14818b27b1ae2048888ac314317c1() {
OptimizedAttributes = null;
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
ssENSupplier = new EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[4];
    all[0] = new BitArray(20,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(28,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENFolioFiles.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENSupplier.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    }else{
    ssENFolio.OptimizedAttributes = value[0];
    ssENFolioFiles.OptimizedAttributes = value[1];
    ssENStorage.OptimizedAttributes = value[2];
    ssENSupplier.OptimizedAttributes = value[3];
    }
}
get{
    BitArray[] all = new BitArray[4];
    all[0] = ssENFolio.OptimizedAttributes;
    all[1] = ssENFolioFiles.OptimizedAttributes;
    all[2] = ssENStorage.OptimizedAttributes;
    all[3] = ssENSupplier.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENFolio.Read( r, ref index);
ssENFolioFiles.Read( r, ref index);
ssENStorage.Read( r, ref index);
ssENSupplier.Read( r, ref index);
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
public void ReadIM(RC_c6c14818b27b1ae2048888ac314317c1 r) {
this = r;
}


public static bool operator == (RC_c6c14818b27b1ae2048888ac314317c1 a, RC_c6c14818b27b1ae2048888ac314317c1 b) {
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioFiles != b.ssENFolioFiles) return false;
if (a.ssENStorage != b.ssENStorage) return false;
if (a.ssENSupplier != b.ssENSupplier) return false;
return true;
}

public static bool operator != (RC_c6c14818b27b1ae2048888ac314317c1 a, RC_c6c14818b27b1ae2048888ac314317c1 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_c6c14818b27b1ae2048888ac314317c1)) return false;
return (this == (RC_c6c14818b27b1ae2048888ac314317c1)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioFiles.GetHashCode()
 ^ ssENStorage.GetHashCode()
 ^ ssENSupplier.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENFolio.RecursiveReset();
ssENFolioFiles.RecursiveReset();
ssENStorage.RecursiveReset();
ssENSupplier.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENFolio.InternalRecursiveSave();
ssENFolioFiles.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
ssENSupplier.InternalRecursiveSave();
}


public RC_c6c14818b27b1ae2048888ac314317c1 Duplicate() {
RC_c6c14818b27b1ae2048888ac314317c1 t;
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioFiles = (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord)this.ssENFolioFiles.Duplicate();
t.ssENStorage = (EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord)this.ssENStorage.Duplicate();
t.ssENSupplier = (EN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord)this.ssENSupplier.Duplicate();
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
if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "foliofiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioFiles")) variable.Value = ssENFolioFiles; else variable.Optimized = true;
variable.SetFieldName("foliofiles");
} else if (head == "storage") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Storage")) variable.Value = ssENStorage; else variable.Optimized = true;
variable.SetFieldName("storage");
} else if (head == "supplier") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Supplier")) variable.Value = ssENSupplier; else variable.Optimized = true;
variable.SetFieldName("supplier");
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
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioFiles) {
return ssENFolioFiles;
}
if (key == IdStorage) {
return ssENStorage;
}
if (key == IdSupplier) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioFiles.Key.AsGuid) {
return ssENFolioFiles;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
if (attributeKey == IdSupplier.Key.AsGuid) {
return ssENSupplier;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioFiles.FillFromOther((IRecord) other.AttributeGet(IdFolioFiles));
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
ssENSupplier.FillFromOther((IRecord) other.AttributeGet(IdSupplier));
}
} // RC_c6c14818b27b1ae2048888ac314317c1
/// <summary>
/// RecordList type <code>FolioFolioFilesStorageSupplierRecordList</code> that represents a record list
///  of <code>Folio, FolioFiles, Storage, Supplier</code>
/// </summary>
public partial class RL_e98bb88ed92fb603b0cfe20670483f89 : GenericRecordList<RC_c6c14818b27b1ae2048888ac314317c1>, IEnumerable, IEnumerator {

protected override RC_c6c14818b27b1ae2048888ac314317c1 GetElementDefaultValue() {
return new RC_c6c14818b27b1ae2048888ac314317c1();
}

public T[] ToArray<T>(Func<RC_c6c14818b27b1ae2048888ac314317c1, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_e98bb88ed92fb603b0cfe20670483f89 recordList, Func<RC_c6c14818b27b1ae2048888ac314317c1, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_e98bb88ed92fb603b0cfe20670483f89(RC_c6c14818b27b1ae2048888ac314317c1[] array) {
  RL_e98bb88ed92fb603b0cfe20670483f89 result = new RL_e98bb88ed92fb603b0cfe20670483f89();
result.InnerFromArray(array);
    return result;
}

public static RL_e98bb88ed92fb603b0cfe20670483f89 ToList<T>(T[] array, Func <T, RC_c6c14818b27b1ae2048888ac314317c1> converter) {
  RL_e98bb88ed92fb603b0cfe20670483f89 result = new RL_e98bb88ed92fb603b0cfe20670483f89();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_e98bb88ed92fb603b0cfe20670483f89 FromRestList<T>(RestList<T> restList, Func <T, RC_c6c14818b27b1ae2048888ac314317c1> converter) {
  RL_e98bb88ed92fb603b0cfe20670483f89 result = new RL_e98bb88ed92fb603b0cfe20670483f89();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_e98bb88ed92fb603b0cfe20670483f89() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[4];
def[0] = new BitArray(20,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(28,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_c6c14818b27b1ae2048888ac314317c1> NewList() {
return new RL_e98bb88ed92fb603b0cfe20670483f89();
}


} // RL_e98bb88ed92fb603b0cfe20670483f89
}

