namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (WoiIGhdegEKgUrx6wPXkXQ)
///  <code>RC_d5cf1eb3da0d77e41669d2183b5af20e</code> that represents <code>AccountingTableRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: AccountingTableRecord
public partial struct RC_d5cf1eb3da0d77e41669d2183b5af20e : ITypedRecord<RC_d5cf1eb3da0d77e41669d2183b5af20e> {
internal static readonly GlobalObjectKey IdAccountingTable = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*sx7P1Q3a5HcWadIYO1ryDg");

public ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure ssSTAccountingTable;


public static implicit operator ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure( RC_d5cf1eb3da0d77e41669d2183b5af20e r) {
return r.ssSTAccountingTable;
}

public static implicit operator RC_d5cf1eb3da0d77e41669d2183b5af20e (ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure r) {
RC_d5cf1eb3da0d77e41669d2183b5af20e res = new RC_d5cf1eb3da0d77e41669d2183b5af20e ();
res.ssSTAccountingTable = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_d5cf1eb3da0d77e41669d2183b5af20e() {
OptimizedAttributes = null;
ssSTAccountingTable = new ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure();
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
    ssSTAccountingTable.OptimizedAttributes = value[0];
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
ssSTAccountingTable.Read( r, ref index);
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
public void ReadIM(RC_d5cf1eb3da0d77e41669d2183b5af20e r) {
this = r;
}


public static bool operator == (RC_d5cf1eb3da0d77e41669d2183b5af20e a, RC_d5cf1eb3da0d77e41669d2183b5af20e b) {
if (a.ssSTAccountingTable != b.ssSTAccountingTable) return false;
return true;
}

public static bool operator != (RC_d5cf1eb3da0d77e41669d2183b5af20e a, RC_d5cf1eb3da0d77e41669d2183b5af20e b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_d5cf1eb3da0d77e41669d2183b5af20e)) return false;
return (this == (RC_d5cf1eb3da0d77e41669d2183b5af20e)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTAccountingTable.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTAccountingTable.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTAccountingTable.InternalRecursiveSave();
}


public RC_d5cf1eb3da0d77e41669d2183b5af20e Duplicate() {
RC_d5cf1eb3da0d77e41669d2183b5af20e t;
t.ssSTAccountingTable = (ST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure)this.ssSTAccountingTable.Duplicate();
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
if (head == "accountingtable") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".AccountingTable")) variable.Value = ssSTAccountingTable; else variable.Optimized = true;
variable.SetFieldName("accountingtable");
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
if (key == IdAccountingTable) {
return ssSTAccountingTable;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdAccountingTable.Key.AsGuid) {
return ssSTAccountingTable;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTAccountingTable.FillFromOther((IRecord) other.AttributeGet(IdAccountingTable));
}
} // RC_d5cf1eb3da0d77e41669d2183b5af20e
/// <summary>
/// RecordList type <code>AccountingTableRecordList</code> that represents a record list of
///  <code>AccountingTable</code>
/// </summary>
public partial class RL_190e9d4a817f3b64dbcd960d93e355a0 : GenericRecordList<RC_d5cf1eb3da0d77e41669d2183b5af20e>, IEnumerable, IEnumerator {

protected override RC_d5cf1eb3da0d77e41669d2183b5af20e GetElementDefaultValue() {
return new RC_d5cf1eb3da0d77e41669d2183b5af20e();
}

public T[] ToArray<T>(Func<RC_d5cf1eb3da0d77e41669d2183b5af20e, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_190e9d4a817f3b64dbcd960d93e355a0 recordList, Func<RC_d5cf1eb3da0d77e41669d2183b5af20e, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_190e9d4a817f3b64dbcd960d93e355a0(RC_d5cf1eb3da0d77e41669d2183b5af20e[] array) {
  RL_190e9d4a817f3b64dbcd960d93e355a0 result = new RL_190e9d4a817f3b64dbcd960d93e355a0();
result.InnerFromArray(array);
    return result;
}

public static RL_190e9d4a817f3b64dbcd960d93e355a0 ToList<T>(T[] array, Func <T, RC_d5cf1eb3da0d77e41669d2183b5af20e> converter) {
  RL_190e9d4a817f3b64dbcd960d93e355a0 result = new RL_190e9d4a817f3b64dbcd960d93e355a0();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_190e9d4a817f3b64dbcd960d93e355a0 FromRestList<T>(RestList<T> restList, Func <T, RC_d5cf1eb3da0d77e41669d2183b5af20e> converter) {
  RL_190e9d4a817f3b64dbcd960d93e355a0 result = new RL_190e9d4a817f3b64dbcd960d93e355a0();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_190e9d4a817f3b64dbcd960d93e355a0() : base() {
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
protected override OSList<RC_d5cf1eb3da0d77e41669d2183b5af20e> NewList() {
return new RL_190e9d4a817f3b64dbcd960d93e355a0();
}


} // RL_190e9d4a817f3b64dbcd960d93e355a0
}

