namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (5H_jsdUre0ieNFDjUb6YJg)
///  <code>RC_decd99b444cc9b15cdd3bf7e05218957</code> that represent
/// s <code>UserInvoiceFileIsSelectedStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceFileIsSelectedStorageRecord
public partial struct RC_decd99b444cc9b15cdd3bf7e05218957 : ITypedRecord<RC_decd99b444cc9b15cdd3bf7e05218957> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public ENUserEntityRecord ssENUser;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public bool ssIsSelected;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_decd99b444cc9b15cdd3bf7e05218957() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssIsSelected = false;
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    all[2] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceFile.OptimizedAttributes = value[1];
    ssENStorage.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
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
ssENUser.Read( r, ref index);
ssENInvoiceFile.Read( r, ref index);
ssIsSelected = r.ReadBoolean(index++, "UserInvoiceFileIsSelectedStorageRecord.IsSelected", false);
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
public void ReadIM(RC_decd99b444cc9b15cdd3bf7e05218957 r) {
this = r;
}


public static bool operator == (RC_decd99b444cc9b15cdd3bf7e05218957 a, RC_decd99b444cc9b15cdd3bf7e05218957 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_decd99b444cc9b15cdd3bf7e05218957 a, RC_decd99b444cc9b15cdd3bf7e05218957 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_decd99b444cc9b15cdd3bf7e05218957)) return false;
return (this == (RC_decd99b444cc9b15cdd3bf7e05218957)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_decd99b444cc9b15cdd3bf7e05218957 Duplicate() {
RC_decd99b444cc9b15cdd3bf7e05218957 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
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
} else if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
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
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
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
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
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
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_decd99b444cc9b15cdd3bf7e05218957
/// <summary>
/// RecordList type <code>UserInvoiceFileIsSelectedStorageRecordList</code> that represents a record
///  list of <code>User, InvoiceFile, Boolean, Storage</code>
/// </summary>
public partial class RL_07b8f645e21d019f14a92adf1e622672 : GenericRecordList<RC_decd99b444cc9b15cdd3bf7e05218957>, IEnumerable, IEnumerator {

protected override RC_decd99b444cc9b15cdd3bf7e05218957 GetElementDefaultValue() {
return new RC_decd99b444cc9b15cdd3bf7e05218957();
}

public T[] ToArray<T>(Func<RC_decd99b444cc9b15cdd3bf7e05218957, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_07b8f645e21d019f14a92adf1e622672 recordList, Func<RC_decd99b444cc9b15cdd3bf7e05218957, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_07b8f645e21d019f14a92adf1e622672(RC_decd99b444cc9b15cdd3bf7e05218957[] array) {
  RL_07b8f645e21d019f14a92adf1e622672 result = new RL_07b8f645e21d019f14a92adf1e622672();
result.InnerFromArray(array);
    return result;
}

public static RL_07b8f645e21d019f14a92adf1e622672 ToList<T>(T[] array, Func <T, RC_decd99b444cc9b15cdd3bf7e05218957> converter) {
  RL_07b8f645e21d019f14a92adf1e622672 result = new RL_07b8f645e21d019f14a92adf1e622672();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_07b8f645e21d019f14a92adf1e622672 FromRestList<T>(RestList<T> restList, Func <T, RC_decd99b444cc9b15cdd3bf7e05218957> converter) {
  RL_07b8f645e21d019f14a92adf1e622672 result = new RL_07b8f645e21d019f14a92adf1e622672();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_07b8f645e21d019f14a92adf1e622672() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
def[2] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_decd99b444cc9b15cdd3bf7e05218957> NewList() {
return new RL_07b8f645e21d019f14a92adf1e622672();
}


} // RL_07b8f645e21d019f14a92adf1e622672
}

