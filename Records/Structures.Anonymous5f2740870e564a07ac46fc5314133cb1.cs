namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (h0AnX1YOB0qsRvxTFBM8sQ)
///  <code>RC_45a70b1c41f3feae858ee1f6db902f7d</code> that represent
/// s <code>UserInvoiceFolioFolioFilesIsSelectedStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceFolioFolioFilesIsSelectedStorageRecord
public partial struct RC_45a70b1c41f3feae858ee1f6db902f7d : ITypedRecord<RC_45a70b1c41f3feae858ee1f6db902f7d> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdFolio = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+Czrz7YK54PZqbXQLZyVJg");
internal static readonly GlobalObjectKey IdFolioFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*qLf9KPiu3JGSHF_jQ5OlaQ");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord ssENFolio;

public EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord ssENFolioFiles;

public bool ssIsSelected;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_45a70b1c41f3feae858ee1f6db902f7d() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENFolio = new EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
ssENFolioFiles = new EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord();
ssIsSelected = false;
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[5];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(20,false);
    all[3] = new BitArray(8,false);
    all[4] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENFolio.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    ssENFolioFiles.OptimizedAttributes = GetDefaultOptimizedValues()[3];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[4];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENFolio.OptimizedAttributes = value[2];
    ssENFolioFiles.OptimizedAttributes = value[3];
    ssENStorage.OptimizedAttributes = value[4];
    }
}
get{
    BitArray[] all = new BitArray[5];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENFolio.OptimizedAttributes;
    all[3] = ssENFolioFiles.OptimizedAttributes;
    all[4] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENUser.Read( r, ref index);
ssENInvoice.Read( r, ref index);
ssENFolio.Read( r, ref index);
ssENFolioFiles.Read( r, ref index);
ssIsSelected = r.ReadBoolean(index++, "UserInvoiceFolioFolioFilesIsSelectedStorageRecord.IsSelected", false);
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
public void ReadIM(RC_45a70b1c41f3feae858ee1f6db902f7d r) {
this = r;
}


public static bool operator == (RC_45a70b1c41f3feae858ee1f6db902f7d a, RC_45a70b1c41f3feae858ee1f6db902f7d b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENFolio != b.ssENFolio) return false;
if (a.ssENFolioFiles != b.ssENFolioFiles) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_45a70b1c41f3feae858ee1f6db902f7d a, RC_45a70b1c41f3feae858ee1f6db902f7d b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_45a70b1c41f3feae858ee1f6db902f7d)) return false;
return (this == (RC_45a70b1c41f3feae858ee1f6db902f7d)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENFolio.GetHashCode()
 ^ ssENFolioFiles.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENFolio.RecursiveReset();
ssENFolioFiles.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENFolio.InternalRecursiveSave();
ssENFolioFiles.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_45a70b1c41f3feae858ee1f6db902f7d Duplicate() {
RC_45a70b1c41f3feae858ee1f6db902f7d t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENFolio = (EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord)this.ssENFolio.Duplicate();
t.ssENFolioFiles = (EN_b64035ee1e9a04282d937f5f4e7a7952EntityRecord)this.ssENFolioFiles.Duplicate();
t.ssIsSelected = this.ssIsSelected;
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
if (head == "user") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".User")) variable.Value = ssENUser; else variable.Optimized = true;
variable.SetFieldName("user");
} else if (head == "invoice") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Invoice")) variable.Value = ssENInvoice; else variable.Optimized = true;
variable.SetFieldName("invoice");
} else if (head == "folio") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Folio")) variable.Value = ssENFolio; else variable.Optimized = true;
variable.SetFieldName("folio");
} else if (head == "foliofiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".FolioFiles")) variable.Value = ssENFolioFiles; else variable.Optimized = true;
variable.SetFieldName("foliofiles");
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdUser) {
return ssENUser;
}
if (key == IdInvoice) {
return ssENInvoice;
}
if (key == IdFolio) {
return ssENFolio;
}
if (key == IdFolioFiles) {
return ssENFolioFiles;
}
if (key == IdIsSelected) {
return ssIsSelected;
}
if (key == IdStorage) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdUser.Key.AsGuid) {
return ssENUser;
}
if (attributeKey == IdInvoice.Key.AsGuid) {
return ssENInvoice;
}
if (attributeKey == IdFolio.Key.AsGuid) {
return ssENFolio;
}
if (attributeKey == IdFolioFiles.Key.AsGuid) {
return ssENFolioFiles;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
if (attributeKey == IdStorage.Key.AsGuid) {
return ssENStorage;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENFolio.FillFromOther((IRecord) other.AttributeGet(IdFolio));
ssENFolioFiles.FillFromOther((IRecord) other.AttributeGet(IdFolioFiles));
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_45a70b1c41f3feae858ee1f6db902f7d
/// <summary>
/// RecordList type <code>UserInvoiceFolioFolioFilesIsSelectedStorageRecordList</code> that represents
///  a record list of <code>User, Invoice, Folio, FolioFiles, Boolean, Storage</code>
/// </summary>
public partial class RL_1cd2619da83763aa8c2844c03d756d5b : GenericRecordList<RC_45a70b1c41f3feae858ee1f6db902f7d>, IEnumerable, IEnumerator {

protected override RC_45a70b1c41f3feae858ee1f6db902f7d GetElementDefaultValue() {
return new RC_45a70b1c41f3feae858ee1f6db902f7d();
}

public T[] ToArray<T>(Func<RC_45a70b1c41f3feae858ee1f6db902f7d, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1cd2619da83763aa8c2844c03d756d5b recordList, Func<RC_45a70b1c41f3feae858ee1f6db902f7d, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1cd2619da83763aa8c2844c03d756d5b(RC_45a70b1c41f3feae858ee1f6db902f7d[] array) {
  RL_1cd2619da83763aa8c2844c03d756d5b result = new RL_1cd2619da83763aa8c2844c03d756d5b();
result.InnerFromArray(array);
    return result;
}

public static RL_1cd2619da83763aa8c2844c03d756d5b ToList<T>(T[] array, Func <T, RC_45a70b1c41f3feae858ee1f6db902f7d> converter) {
  RL_1cd2619da83763aa8c2844c03d756d5b result = new RL_1cd2619da83763aa8c2844c03d756d5b();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1cd2619da83763aa8c2844c03d756d5b FromRestList<T>(RestList<T> restList, Func <T, RC_45a70b1c41f3feae858ee1f6db902f7d> converter) {
  RL_1cd2619da83763aa8c2844c03d756d5b result = new RL_1cd2619da83763aa8c2844c03d756d5b();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1cd2619da83763aa8c2844c03d756d5b() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[5];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(20,false);
def[3] = new BitArray(8,false);
def[4] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_45a70b1c41f3feae858ee1f6db902f7d> NewList() {
return new RL_1cd2619da83763aa8c2844c03d756d5b();
}


} // RL_1cd2619da83763aa8c2844c03d756d5b
}

