namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (4SnhMq5WOUqlbJ0ncRSLpw)
///  <code>RC_0e55d0fdd23b58fdb0cbf299c27a7912</code> that represent
/// s <code>UserInvoiceFileSizeIsSelectedRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceFileSizeIsSelectedRecord
public partial struct RC_0e55d0fdd23b58fdb0cbf299c27a7912 : ITypedRecord<RC_0e55d0fdd23b58fdb0cbf299c27a7912> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");
internal static readonly GlobalObjectKey IdSize = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*nBRlRzQ7ytwgFu9xuO0JCA");
internal static readonly GlobalObjectKey IdIsSelected = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*osqdCCbTPm0O_HzjZIVgPA");

public ENUserEntityRecord ssENUser;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;

public long ssSize;

public bool ssIsSelected;


public BitArray OptimizedAttributes;

public RC_0e55d0fdd23b58fdb0cbf299c27a7912() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
ssSize = 0L;
ssIsSelected = false;
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[2];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoiceFile.OptimizedAttributes = value[1];
    }
}
get{
    BitArray[] all = new BitArray[2];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoiceFile.OptimizedAttributes;
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
ssSize = r.ReadLongInteger(index++, "UserInvoiceFileSizeIsSelectedRecord.Size", 0L);
ssIsSelected = r.ReadBoolean(index++, "UserInvoiceFileSizeIsSelectedRecord.IsSelected", false);
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
public void ReadIM(RC_0e55d0fdd23b58fdb0cbf299c27a7912 r) {
this = r;
}


public static bool operator == (RC_0e55d0fdd23b58fdb0cbf299c27a7912 a, RC_0e55d0fdd23b58fdb0cbf299c27a7912 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
if (a.ssSize != b.ssSize) return false;
if (a.ssIsSelected != b.ssIsSelected) return false;
return true;
}

public static bool operator != (RC_0e55d0fdd23b58fdb0cbf299c27a7912 a, RC_0e55d0fdd23b58fdb0cbf299c27a7912 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_0e55d0fdd23b58fdb0cbf299c27a7912)) return false;
return (this == (RC_0e55d0fdd23b58fdb0cbf299c27a7912)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
 ^ ssSize.GetHashCode()
 ^ ssIsSelected.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
}


public RC_0e55d0fdd23b58fdb0cbf299c27a7912 Duplicate() {
RC_0e55d0fdd23b58fdb0cbf299c27a7912 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
t.ssSize = this.ssSize;
t.ssIsSelected = this.ssIsSelected;
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
} else if (head == "size") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Size")) variable.Value = ssSize; else variable.Optimized = true;
} else if (head == "isselected") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".IsSelected")) variable.Value = ssIsSelected; else variable.Optimized = true;
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
if (key == IdSize) {
return ssSize;
}
if (key == IdIsSelected) {
return ssIsSelected;
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
if (attributeKey == IdSize.Key.AsGuid) {
return ssSize;
}
if (attributeKey == IdIsSelected.Key.AsGuid) {
return ssIsSelected;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
ssSize = (long) other.AttributeGet(IdSize);
ssIsSelected = (bool) other.AttributeGet(IdIsSelected);
}
} // RC_0e55d0fdd23b58fdb0cbf299c27a7912
/// <summary>
/// RecordList type <code>UserInvoiceFileSizeIsSelectedRecordList</code> that represents a record list
///  of <code>User, InvoiceFile, LongInteger, Boolean</code>
/// </summary>
public partial class RL_2813f8fd192cd70bce8748716703a824 : GenericRecordList<RC_0e55d0fdd23b58fdb0cbf299c27a7912>, IEnumerable, IEnumerator {

protected override RC_0e55d0fdd23b58fdb0cbf299c27a7912 GetElementDefaultValue() {
return new RC_0e55d0fdd23b58fdb0cbf299c27a7912();
}

public T[] ToArray<T>(Func<RC_0e55d0fdd23b58fdb0cbf299c27a7912, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_2813f8fd192cd70bce8748716703a824 recordList, Func<RC_0e55d0fdd23b58fdb0cbf299c27a7912, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_2813f8fd192cd70bce8748716703a824(RC_0e55d0fdd23b58fdb0cbf299c27a7912[] array) {
  RL_2813f8fd192cd70bce8748716703a824 result = new RL_2813f8fd192cd70bce8748716703a824();
result.InnerFromArray(array);
    return result;
}

public static RL_2813f8fd192cd70bce8748716703a824 ToList<T>(T[] array, Func <T, RC_0e55d0fdd23b58fdb0cbf299c27a7912> converter) {
  RL_2813f8fd192cd70bce8748716703a824 result = new RL_2813f8fd192cd70bce8748716703a824();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_2813f8fd192cd70bce8748716703a824 FromRestList<T>(RestList<T> restList, Func <T, RC_0e55d0fdd23b58fdb0cbf299c27a7912> converter) {
  RL_2813f8fd192cd70bce8748716703a824 result = new RL_2813f8fd192cd70bce8748716703a824();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_2813f8fd192cd70bce8748716703a824() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[2];
def[0] = new BitArray(5,false);
def[1] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_0e55d0fdd23b58fdb0cbf299c27a7912> NewList() {
return new RL_2813f8fd192cd70bce8748716703a824();
}


} // RL_2813f8fd192cd70bce8748716703a824
}

