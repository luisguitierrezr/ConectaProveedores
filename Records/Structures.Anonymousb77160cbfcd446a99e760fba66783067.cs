namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (y2Bxt9T8qUaedg+6ZngwZw)
///  <code>RC_87351e3b0fa2ca59cf6c6749c6405006</code> that represents <code>ColorRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: ColorRecord
public partial struct RC_87351e3b0fa2ca59cf6c6749c6405006 : ITypedRecord<RC_87351e3b0fa2ca59cf6c6749c6405006> {
internal static readonly GlobalObjectKey IdColor = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*Ox41h6IPWcrPbGdJxkBQBg");

public EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord ssENColor;


public static implicit operator EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord( RC_87351e3b0fa2ca59cf6c6749c6405006 r) {
return r.ssENColor;
}

public static implicit operator RC_87351e3b0fa2ca59cf6c6749c6405006 (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord r) {
RC_87351e3b0fa2ca59cf6c6749c6405006 res = new RC_87351e3b0fa2ca59cf6c6749c6405006 ();
res.ssENColor = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENColor.ChangedAttributes = value;
}
get {
    return ssENColor.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_87351e3b0fa2ca59cf6c6749c6405006() {
OptimizedAttributes = null;
ssENColor = new EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(2,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENColor.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENColor.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENColor.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENColor.Read( r, ref index);
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
public void ReadIM(RC_87351e3b0fa2ca59cf6c6749c6405006 r) {
this = r;
}


public static bool operator == (RC_87351e3b0fa2ca59cf6c6749c6405006 a, RC_87351e3b0fa2ca59cf6c6749c6405006 b) {
if (a.ssENColor != b.ssENColor) return false;
return true;
}

public static bool operator != (RC_87351e3b0fa2ca59cf6c6749c6405006 a, RC_87351e3b0fa2ca59cf6c6749c6405006 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_87351e3b0fa2ca59cf6c6749c6405006)) return false;
return (this == (RC_87351e3b0fa2ca59cf6c6749c6405006)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENColor.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENColor.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENColor.InternalRecursiveSave();
}


public RC_87351e3b0fa2ca59cf6c6749c6405006 Duplicate() {
RC_87351e3b0fa2ca59cf6c6749c6405006 t;
t.ssENColor = (EN_849d11ab47adc426b5ce8d8c815c4fbfEntityRecord)this.ssENColor.Duplicate();
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
if (head == "color") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Color")) variable.Value = ssENColor; else variable.Optimized = true;
variable.SetFieldName("color");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENColor.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENColor.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdColor) {
return ssENColor;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdColor.Key.AsGuid) {
return ssENColor;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENColor.FillFromOther((IRecord) other.AttributeGet(IdColor));
}
} // RC_87351e3b0fa2ca59cf6c6749c6405006
/// <summary>
/// RecordList type <code>ColorRecordList</code> that represents a record list of <code>Color</code>
/// </summary>
public partial class RL_9e8eb507fc82c7005600a2499b6a668c : GenericRecordList<RC_87351e3b0fa2ca59cf6c6749c6405006>, IEnumerable, IEnumerator {

protected override RC_87351e3b0fa2ca59cf6c6749c6405006 GetElementDefaultValue() {
return new RC_87351e3b0fa2ca59cf6c6749c6405006();
}

public T[] ToArray<T>(Func<RC_87351e3b0fa2ca59cf6c6749c6405006, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9e8eb507fc82c7005600a2499b6a668c recordList, Func<RC_87351e3b0fa2ca59cf6c6749c6405006, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9e8eb507fc82c7005600a2499b6a668c(RC_87351e3b0fa2ca59cf6c6749c6405006[] array) {
  RL_9e8eb507fc82c7005600a2499b6a668c result = new RL_9e8eb507fc82c7005600a2499b6a668c();
result.InnerFromArray(array);
    return result;
}

public static RL_9e8eb507fc82c7005600a2499b6a668c ToList<T>(T[] array, Func <T, RC_87351e3b0fa2ca59cf6c6749c6405006> converter) {
  RL_9e8eb507fc82c7005600a2499b6a668c result = new RL_9e8eb507fc82c7005600a2499b6a668c();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9e8eb507fc82c7005600a2499b6a668c FromRestList<T>(RestList<T> restList, Func <T, RC_87351e3b0fa2ca59cf6c6749c6405006> converter) {
  RL_9e8eb507fc82c7005600a2499b6a668c result = new RL_9e8eb507fc82c7005600a2499b6a668c();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9e8eb507fc82c7005600a2499b6a668c() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(2,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_87351e3b0fa2ca59cf6c6749c6405006> NewList() {
return new RL_9e8eb507fc82c7005600a2499b6a668c();
}


} // RL_9e8eb507fc82c7005600a2499b6a668c
}

