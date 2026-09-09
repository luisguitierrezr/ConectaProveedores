namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (y3midKy6QkaFB36T0UXVpw)
///  <code>RC_eb0c76f6f640a3fe05b6e66cf112863f</code> that represent
/// s <code>InvoiceFileIsSelectedStorageRecord</code> <p>Description: </p>
/// </summary>
// Name: InvoiceFileIsSelectedStorageRecord
public partial struct RC_eb0c76f6f640a3fe05b6e66cf112863f : ITypedRecord<RC_eb0c76f6f640a3fe05b6e66cf112863f> {
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");
internal static readonly GlobalObjectKey IdStorage = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*k_HtsgKSfutg60mTSTiFFA");

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public bool ssIsSelected;

public EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord ssENStorage;


public BitArray OptimizedAttributes;

public RC_eb0c76f6f640a3fe05b6e66cf112863f() {
OptimizedAttributes = null;
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssIsSelected = false;
ssENStorage = new EN_2813b07c5f0dbb947aaac592d78e8ebaEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(8,false);
    all[1] = new BitArray(20,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENStorage.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENInvoiceFile.OptimizedAttributes = value[0];
    ssENStorage.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENInvoiceFile.OptimizedAttributes;
    all[1] = ssENStorage.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENInvoiceFile.Read( r, ref index);
ssIsSelected = r.ReadBoolean(index++, "InvoiceFileIsSelectedStorageRecord.IsSelected", false);
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
public void ReadIM(RC_eb0c76f6f640a3fe05b6e66cf112863f r) {
this = r;
}


public static bool operator == (RC_eb0c76f6f640a3fe05b6e66cf112863f a, RC_eb0c76f6f640a3fe05b6e66cf112863f b) {
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
if (a.ssENStorage != b.ssENStorage) return false;
return true;
}

public static bool operator != (RC_eb0c76f6f640a3fe05b6e66cf112863f a, RC_eb0c76f6f640a3fe05b6e66cf112863f b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_eb0c76f6f640a3fe05b6e66cf112863f)) return false;
return (this == (RC_eb0c76f6f640a3fe05b6e66cf112863f)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssIsSelected.GetHashCode()
 ^ ssENStorage.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENInvoiceFile.RecursiveReset();
ssENStorage.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENInvoiceFile.InternalRecursiveSave();
ssENStorage.InternalRecursiveSave();
}


public RC_eb0c76f6f640a3fe05b6e66cf112863f Duplicate() {
RC_eb0c76f6f640a3fe05b6e66cf112863f t;
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
if (head == "invoicefile") {
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
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
ssENStorage.FillFromOther((IRecord) other.AttributeGet(IdStorage));
}
} // RC_eb0c76f6f640a3fe05b6e66cf112863f
/// <summary>
/// RecordList type <code>InvoiceFileIsSelectedStorageRecordList</code> that represents a record list
///  of <code>InvoiceFile, Boolean, Storage</code>
/// </summary>
public partial class RL_a8a8885e97333843e8d61cbbac75c28c : GenericRecordList<RC_eb0c76f6f640a3fe05b6e66cf112863f>, IEnumerable, IEnumerator {

protected override RC_eb0c76f6f640a3fe05b6e66cf112863f GetElementDefaultValue() {
return new RC_eb0c76f6f640a3fe05b6e66cf112863f();
}

public T[] ToArray<T>(Func<RC_eb0c76f6f640a3fe05b6e66cf112863f, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_a8a8885e97333843e8d61cbbac75c28c recordList, Func<RC_eb0c76f6f640a3fe05b6e66cf112863f, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_a8a8885e97333843e8d61cbbac75c28c(RC_eb0c76f6f640a3fe05b6e66cf112863f[] array) {
  RL_a8a8885e97333843e8d61cbbac75c28c result = new RL_a8a8885e97333843e8d61cbbac75c28c();
result.InnerFromArray(array);
    return result;
}

public static RL_a8a8885e97333843e8d61cbbac75c28c ToList<T>(T[] array, Func <T, RC_eb0c76f6f640a3fe05b6e66cf112863f> converter) {
  RL_a8a8885e97333843e8d61cbbac75c28c result = new RL_a8a8885e97333843e8d61cbbac75c28c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_a8a8885e97333843e8d61cbbac75c28c FromRestList<T>(RestList<T> restList, Func <T, RC_eb0c76f6f640a3fe05b6e66cf112863f> converter) {
  RL_a8a8885e97333843e8d61cbbac75c28c result = new RL_a8a8885e97333843e8d61cbbac75c28c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_a8a8885e97333843e8d61cbbac75c28c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(8,false);
def[1] = new BitArray(20,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_eb0c76f6f640a3fe05b6e66cf112863f> NewList() {
return new RL_a8a8885e97333843e8d61cbbac75c28c();
}


} // RL_a8a8885e97333843e8d61cbbac75c28c
}

