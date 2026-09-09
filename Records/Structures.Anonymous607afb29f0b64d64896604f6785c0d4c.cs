namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (Kft6YLbwZE2JZgT2eFwNTA)
///  <code>RC_f5e20bd4e0a7c754f3e99b7ff28d38d9</code> that represent
/// s <code>UserInvoiceInvoiceFileRecord</code> <p>Description: </p>
/// </summary>
// Name: UserInvoiceInvoiceFileRecord
public partial struct RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 : ITypedRecord<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> {
internal static readonly GlobalObjectKey IdUser = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*NRPQzoKKE6jx2aUQjxfOeQ");
internal static readonly GlobalObjectKey IdInvoice = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*a5jFBMcyL4IDPJM89xuWvQ");
internal static readonly GlobalObjectKey IdInvoiceFile = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*+AqZGHFv6WkrcStGjhO5Rw");

public ENUserEntityRecord ssENUser;

public EN_d1d0320db36efbb094ad0082361435a0EntityRecord ssENInvoice;

public EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord ssENInvoiceFile;


public BitArray OptimizedAttributes;

public RC_f5e20bd4e0a7c754f3e99b7ff28d38d9() {
OptimizedAttributes = null;
ssENUser = new ENUserEntityRecord();
ssENInvoice = new EN_d1d0320db36efbb094ad0082361435a0EntityRecord();
ssENInvoiceFile = new EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[3];
    all[0] = new BitArray(5,false);
    all[1] = new BitArray(24,false);
    all[2] = new BitArray(8,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENUser.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    ssENInvoice.OptimizedAttributes = GetDefaultOptimizedValues()[1];
    ssENInvoiceFile.OptimizedAttributes = GetDefaultOptimizedValues()[2];
    }else{
    ssENUser.OptimizedAttributes = value[0];
    ssENInvoice.OptimizedAttributes = value[1];
    ssENInvoiceFile.OptimizedAttributes = value[2];
    }
}
get{
    BitArray[] all = new BitArray[3];
    all[0] = ssENUser.OptimizedAttributes;
    all[1] = ssENInvoice.OptimizedAttributes;
    all[2] = ssENInvoiceFile.OptimizedAttributes;
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
ssENInvoiceFile.Read( r, ref index);
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
public void ReadIM(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 r) {
this = r;
}


public static bool operator == (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 a, RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 b) {
if (a.ssENUser != b.ssENUser) return false;
if (a.ssENInvoice != b.ssENInvoice) return false;
if (a.ssENInvoiceFile != b.ssENInvoiceFile) return false;
return true;
}

public static bool operator != (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 a, RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9)) return false;
return (this == (RC_f5e20bd4e0a7c754f3e99b7ff28d38d9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENUser.GetHashCode()
 ^ ssENInvoice.GetHashCode()
 ^ ssENInvoiceFile.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENUser.RecursiveReset();
ssENInvoice.RecursiveReset();
ssENInvoiceFile.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENUser.InternalRecursiveSave();
ssENInvoice.InternalRecursiveSave();
ssENInvoiceFile.InternalRecursiveSave();
}


public RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 Duplicate() {
RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 t;
t.ssENUser = (ENUserEntityRecord)this.ssENUser.Duplicate();
t.ssENInvoice = (EN_d1d0320db36efbb094ad0082361435a0EntityRecord)this.ssENInvoice.Duplicate();
t.ssENInvoiceFile = (EN_f4b3d5ed051c83aa4797b2f52b3a1f06EntityRecord)this.ssENInvoiceFile.Duplicate();
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
} else if (head == "invoicefile") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFile")) variable.Value = ssENInvoiceFile; else variable.Optimized = true;
variable.SetFieldName("invoicefile");
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
if (key == IdInvoiceFile) {
return ssENInvoiceFile;
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
if (attributeKey == IdInvoiceFile.Key.AsGuid) {
return ssENInvoiceFile;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENUser.FillFromOther((IRecord) other.AttributeGet(IdUser));
ssENInvoice.FillFromOther((IRecord) other.AttributeGet(IdInvoice));
ssENInvoiceFile.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFile));
}
} // RC_f5e20bd4e0a7c754f3e99b7ff28d38d9
/// <summary>
/// RecordList type <code>UserInvoiceInvoiceFileRecordList</code> that represents a record list of
///  <code>User, Invoice, InvoiceFile</code>
/// </summary>
public partial class RL_f3a656d1fdc6bd4ad6371c5743799e57 : GenericRecordList<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9>, IEnumerable, IEnumerator {

protected override RC_f5e20bd4e0a7c754f3e99b7ff28d38d9 GetElementDefaultValue() {
return new RC_f5e20bd4e0a7c754f3e99b7ff28d38d9();
}

public T[] ToArray<T>(Func<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_f3a656d1fdc6bd4ad6371c5743799e57 recordList, Func<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_f3a656d1fdc6bd4ad6371c5743799e57(RC_f5e20bd4e0a7c754f3e99b7ff28d38d9[] array) {
  RL_f3a656d1fdc6bd4ad6371c5743799e57 result = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
result.InnerFromArray(array);
    return result;
}

public static RL_f3a656d1fdc6bd4ad6371c5743799e57 ToList<T>(T[] array, Func <T, RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> converter) {
  RL_f3a656d1fdc6bd4ad6371c5743799e57 result = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_f3a656d1fdc6bd4ad6371c5743799e57 FromRestList<T>(RestList<T> restList, Func <T, RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> converter) {
  RL_f3a656d1fdc6bd4ad6371c5743799e57 result = new RL_f3a656d1fdc6bd4ad6371c5743799e57();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_f3a656d1fdc6bd4ad6371c5743799e57() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[3];
def[0] = new BitArray(5,false);
def[1] = new BitArray(24,false);
def[2] = new BitArray(8,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f5e20bd4e0a7c754f3e99b7ff28d38d9> NewList() {
return new RL_f3a656d1fdc6bd4ad6371c5743799e57();
}


} // RL_f3a656d1fdc6bd4ad6371c5743799e57
}

