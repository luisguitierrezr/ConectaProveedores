namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (78SdX8+9nUOZAA6JndvCuQ)
///  <code>RC_fcad6692fe9ee374c1913cf07edd9ec9</code> that represents <code>InvoiceFilesRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: InvoiceFilesRecord
public partial struct RC_fcad6692fe9ee374c1913cf07edd9ec9 : ITypedRecord<RC_fcad6692fe9ee374c1913cf07edd9ec9> {
internal static readonly GlobalObjectKey IdInvoiceFiles = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*kmat_J7+dOPBkTzwft2eyQ");

public ST_d381fba44897ce4382b17d5149465d51Structure ssSTInvoiceFiles;


public static implicit operator ST_d381fba44897ce4382b17d5149465d51Structure( RC_fcad6692fe9ee374c1913cf07edd9ec9 r) {
return r.ssSTInvoiceFiles;
}

public static implicit operator RC_fcad6692fe9ee374c1913cf07edd9ec9 (ST_d381fba44897ce4382b17d5149465d51Structure r) {
RC_fcad6692fe9ee374c1913cf07edd9ec9 res = new RC_fcad6692fe9ee374c1913cf07edd9ec9 ();
res.ssSTInvoiceFiles = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_fcad6692fe9ee374c1913cf07edd9ec9() {
OptimizedAttributes = null;
ssSTInvoiceFiles = new ST_d381fba44897ce4382b17d5149465d51Structure();
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
    ssSTInvoiceFiles.OptimizedAttributes = value[0];
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
ssSTInvoiceFiles.Read( r, ref index);
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
public void ReadIM(RC_fcad6692fe9ee374c1913cf07edd9ec9 r) {
this = r;
}


public static bool operator == (RC_fcad6692fe9ee374c1913cf07edd9ec9 a, RC_fcad6692fe9ee374c1913cf07edd9ec9 b) {
if (a.ssSTInvoiceFiles != b.ssSTInvoiceFiles) return false;
return true;
}

public static bool operator != (RC_fcad6692fe9ee374c1913cf07edd9ec9 a, RC_fcad6692fe9ee374c1913cf07edd9ec9 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_fcad6692fe9ee374c1913cf07edd9ec9)) return false;
return (this == (RC_fcad6692fe9ee374c1913cf07edd9ec9)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTInvoiceFiles.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTInvoiceFiles.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTInvoiceFiles.InternalRecursiveSave();
}


public RC_fcad6692fe9ee374c1913cf07edd9ec9 Duplicate() {
RC_fcad6692fe9ee374c1913cf07edd9ec9 t;
t.ssSTInvoiceFiles = (ST_d381fba44897ce4382b17d5149465d51Structure)this.ssSTInvoiceFiles.Duplicate();
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
if (head == "invoicefiles") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".InvoiceFiles")) variable.Value = ssSTInvoiceFiles; else variable.Optimized = true;
variable.SetFieldName("invoicefiles");
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
if (key == IdInvoiceFiles) {
return ssSTInvoiceFiles;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdInvoiceFiles.Key.AsGuid) {
return ssSTInvoiceFiles;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTInvoiceFiles.FillFromOther((IRecord) other.AttributeGet(IdInvoiceFiles));
}
} // RC_fcad6692fe9ee374c1913cf07edd9ec9
/// <summary>
/// RecordList type <code>InvoiceFilesRecordList</code> that represents a record list of
///  <code>InvoiceFiles</code>
/// </summary>
public partial class RL_108f18bbda2f4c3c6b074aad637a4fdb : GenericRecordList<RC_fcad6692fe9ee374c1913cf07edd9ec9>, IEnumerable, IEnumerator {

protected override RC_fcad6692fe9ee374c1913cf07edd9ec9 GetElementDefaultValue() {
return new RC_fcad6692fe9ee374c1913cf07edd9ec9();
}

public T[] ToArray<T>(Func<RC_fcad6692fe9ee374c1913cf07edd9ec9, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_108f18bbda2f4c3c6b074aad637a4fdb recordList, Func<RC_fcad6692fe9ee374c1913cf07edd9ec9, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_108f18bbda2f4c3c6b074aad637a4fdb(RC_fcad6692fe9ee374c1913cf07edd9ec9[] array) {
  RL_108f18bbda2f4c3c6b074aad637a4fdb result = new RL_108f18bbda2f4c3c6b074aad637a4fdb();
result.InnerFromArray(array);
    return result;
}

public static RL_108f18bbda2f4c3c6b074aad637a4fdb ToList<T>(T[] array, Func <T, RC_fcad6692fe9ee374c1913cf07edd9ec9> converter) {
  RL_108f18bbda2f4c3c6b074aad637a4fdb result = new RL_108f18bbda2f4c3c6b074aad637a4fdb();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_108f18bbda2f4c3c6b074aad637a4fdb FromRestList<T>(RestList<T> restList, Func <T, RC_fcad6692fe9ee374c1913cf07edd9ec9> converter) {
  RL_108f18bbda2f4c3c6b074aad637a4fdb result = new RL_108f18bbda2f4c3c6b074aad637a4fdb();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_108f18bbda2f4c3c6b074aad637a4fdb() : base() {
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
protected override OSList<RC_fcad6692fe9ee374c1913cf07edd9ec9> NewList() {
return new RL_108f18bbda2f4c3c6b074aad637a4fdb();
}


} // RL_108f18bbda2f4c3c6b074aad637a4fdb
}

