namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (pJB9bHZpn06I+Bqw30KqRg)
///  <code>RC_f7c59318074340c0e230babd5ea62fb5</code> that represents <code>TelcelDirectionRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: TelcelDirectionRecord
public partial struct RC_f7c59318074340c0e230babd5ea62fb5 : ITypedRecord<RC_f7c59318074340c0e230babd5ea62fb5> {
internal static readonly GlobalObjectKey IdTelcelDirection = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*GJPF90MHwEDiMLq9XqYvtQ");

public EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord ssENTelcelDirection;


public static implicit operator EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord( RC_f7c59318074340c0e230babd5ea62fb5 r) {
return r.ssENTelcelDirection;
}

public static implicit operator RC_f7c59318074340c0e230babd5ea62fb5 (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord r) {
RC_f7c59318074340c0e230babd5ea62fb5 res = new RC_f7c59318074340c0e230babd5ea62fb5 ();
res.ssENTelcelDirection = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENTelcelDirection.ChangedAttributes = value;
}
get {
    return ssENTelcelDirection.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_f7c59318074340c0e230babd5ea62fb5() {
OptimizedAttributes = null;
ssENTelcelDirection = new EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(7,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENTelcelDirection.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENTelcelDirection.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENTelcelDirection.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENTelcelDirection.Read( r, ref index);
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
public void ReadIM(RC_f7c59318074340c0e230babd5ea62fb5 r) {
this = r;
}


public static bool operator == (RC_f7c59318074340c0e230babd5ea62fb5 a, RC_f7c59318074340c0e230babd5ea62fb5 b) {
if (a.ssENTelcelDirection != b.ssENTelcelDirection) return false;
return true;
}

public static bool operator != (RC_f7c59318074340c0e230babd5ea62fb5 a, RC_f7c59318074340c0e230babd5ea62fb5 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_f7c59318074340c0e230babd5ea62fb5)) return false;
return (this == (RC_f7c59318074340c0e230babd5ea62fb5)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENTelcelDirection.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENTelcelDirection.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENTelcelDirection.InternalRecursiveSave();
}


public RC_f7c59318074340c0e230babd5ea62fb5 Duplicate() {
RC_f7c59318074340c0e230babd5ea62fb5 t;
t.ssENTelcelDirection = (EN_d466acc32a9bc0e97d052bc80d6c9d0bEntityRecord)this.ssENTelcelDirection.Duplicate();
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
if (head == "telceldirection") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".TelcelDirection")) variable.Value = ssENTelcelDirection; else variable.Optimized = true;
variable.SetFieldName("telceldirection");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENTelcelDirection.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENTelcelDirection.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdTelcelDirection) {
return ssENTelcelDirection;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdTelcelDirection.Key.AsGuid) {
return ssENTelcelDirection;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENTelcelDirection.FillFromOther((IRecord) other.AttributeGet(IdTelcelDirection));
}
} // RC_f7c59318074340c0e230babd5ea62fb5
/// <summary>
/// RecordList type <code>TelcelDirectionRecordList</code> that represents a record list of
///  <code>TelcelDirection</code>
/// </summary>
public partial class RL_9895159eebcdcdaed80fbd832f52d838 : GenericRecordList<RC_f7c59318074340c0e230babd5ea62fb5>, IEnumerable, IEnumerator {

protected override RC_f7c59318074340c0e230babd5ea62fb5 GetElementDefaultValue() {
return new RC_f7c59318074340c0e230babd5ea62fb5();
}

public T[] ToArray<T>(Func<RC_f7c59318074340c0e230babd5ea62fb5, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_9895159eebcdcdaed80fbd832f52d838 recordList, Func<RC_f7c59318074340c0e230babd5ea62fb5, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_9895159eebcdcdaed80fbd832f52d838(RC_f7c59318074340c0e230babd5ea62fb5[] array) {
  RL_9895159eebcdcdaed80fbd832f52d838 result = new RL_9895159eebcdcdaed80fbd832f52d838();
result.InnerFromArray(array);
    return result;
}

public static RL_9895159eebcdcdaed80fbd832f52d838 ToList<T>(T[] array, Func <T, RC_f7c59318074340c0e230babd5ea62fb5> converter) {
  RL_9895159eebcdcdaed80fbd832f52d838 result = new RL_9895159eebcdcdaed80fbd832f52d838();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_9895159eebcdcdaed80fbd832f52d838 FromRestList<T>(RestList<T> restList, Func <T, RC_f7c59318074340c0e230babd5ea62fb5> converter) {
  RL_9895159eebcdcdaed80fbd832f52d838 result = new RL_9895159eebcdcdaed80fbd832f52d838();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_9895159eebcdcdaed80fbd832f52d838() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(7,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_f7c59318074340c0e230babd5ea62fb5> NewList() {
return new RL_9895159eebcdcdaed80fbd832f52d838();
}


} // RL_9895159eebcdcdaed80fbd832f52d838
}

