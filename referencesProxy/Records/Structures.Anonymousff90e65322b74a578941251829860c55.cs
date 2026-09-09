namespace ssConectaProveedores.ReferencesProxy {
/// <summary>
/// [AnonymousStructure] Record (U+aQ_7ciV0qJQSUYKYYMVQ)
///  <code>RC_b433f1b3ae72f9da85b20eb8b0abb0e8</code> that represents <code>SeriesStylingRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: SeriesStylingRecord
public partial struct RC_b433f1b3ae72f9da85b20eb8b0abb0e8 : ITypedRecord<RC_b433f1b3ae72f9da85b20eb8b0abb0e8> {
internal static readonly GlobalObjectKey IdSeriesStyling = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*s_EztHKu2vmFsg64sKuw6A");

public ST_6bed431434274b65c17cd0339b1ecaa5Structure ssSTSeriesStyling;


public static implicit operator ST_6bed431434274b65c17cd0339b1ecaa5Structure( RC_b433f1b3ae72f9da85b20eb8b0abb0e8 r) {
return r.ssSTSeriesStyling;
}

public static implicit operator RC_b433f1b3ae72f9da85b20eb8b0abb0e8 (ST_6bed431434274b65c17cd0339b1ecaa5Structure r) {
RC_b433f1b3ae72f9da85b20eb8b0abb0e8 res = new RC_b433f1b3ae72f9da85b20eb8b0abb0e8 ();
res.ssSTSeriesStyling = r;
return res;
}

public BitArray OptimizedAttributes;

public RC_b433f1b3ae72f9da85b20eb8b0abb0e8() {
OptimizedAttributes = null;
ssSTSeriesStyling = new ST_6bed431434274b65c17cd0339b1ecaa5Structure();
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
    ssSTSeriesStyling.OptimizedAttributes = value[0];
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
ssSTSeriesStyling.Read( r, ref index);
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
public void ReadIM(RC_b433f1b3ae72f9da85b20eb8b0abb0e8 r) {
this = r;
}


public static bool operator == (RC_b433f1b3ae72f9da85b20eb8b0abb0e8 a, RC_b433f1b3ae72f9da85b20eb8b0abb0e8 b) {
if (a.ssSTSeriesStyling != b.ssSTSeriesStyling) return false;
return true;
}

public static bool operator != (RC_b433f1b3ae72f9da85b20eb8b0abb0e8 a, RC_b433f1b3ae72f9da85b20eb8b0abb0e8 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_b433f1b3ae72f9da85b20eb8b0abb0e8)) return false;
return (this == (RC_b433f1b3ae72f9da85b20eb8b0abb0e8)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssSTSeriesStyling.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssSTSeriesStyling.RecursiveReset();
}

public void InternalRecursiveSave() {
ssSTSeriesStyling.InternalRecursiveSave();
}


public RC_b433f1b3ae72f9da85b20eb8b0abb0e8 Duplicate() {
RC_b433f1b3ae72f9da85b20eb8b0abb0e8 t;
t.ssSTSeriesStyling = (ST_6bed431434274b65c17cd0339b1ecaa5Structure)this.ssSTSeriesStyling.Duplicate();
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
if (head == "seriesstyling") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".SeriesStyling")) variable.Value = ssSTSeriesStyling; else variable.Optimized = true;
variable.SetFieldName("seriesstyling");
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
if (key == IdSeriesStyling) {
return ssSTSeriesStyling;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdSeriesStyling.Key.AsGuid) {
return ssSTSeriesStyling;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssSTSeriesStyling.FillFromOther((IRecord) other.AttributeGet(IdSeriesStyling));
}
} // RC_b433f1b3ae72f9da85b20eb8b0abb0e8
/// <summary>
/// RecordList type <code>SeriesStylingRecordList</code> that represents a record list of
///  <code>SeriesStyling</code>
/// </summary>
public partial class RL_593f1556a13a137f08b3b2af31250b5a : GenericRecordList<RC_b433f1b3ae72f9da85b20eb8b0abb0e8>, IEnumerable, IEnumerator {

protected override RC_b433f1b3ae72f9da85b20eb8b0abb0e8 GetElementDefaultValue() {
return new RC_b433f1b3ae72f9da85b20eb8b0abb0e8();
}

public T[] ToArray<T>(Func<RC_b433f1b3ae72f9da85b20eb8b0abb0e8, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_593f1556a13a137f08b3b2af31250b5a recordList, Func<RC_b433f1b3ae72f9da85b20eb8b0abb0e8, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_593f1556a13a137f08b3b2af31250b5a(RC_b433f1b3ae72f9da85b20eb8b0abb0e8[] array) {
  RL_593f1556a13a137f08b3b2af31250b5a result = new RL_593f1556a13a137f08b3b2af31250b5a();
result.InnerFromArray(array);
    return result;
}

public static RL_593f1556a13a137f08b3b2af31250b5a ToList<T>(T[] array, Func <T, RC_b433f1b3ae72f9da85b20eb8b0abb0e8> converter) {
  RL_593f1556a13a137f08b3b2af31250b5a result = new RL_593f1556a13a137f08b3b2af31250b5a();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_593f1556a13a137f08b3b2af31250b5a FromRestList<T>(RestList<T> restList, Func <T, RC_b433f1b3ae72f9da85b20eb8b0abb0e8> converter) {
  RL_593f1556a13a137f08b3b2af31250b5a result = new RL_593f1556a13a137f08b3b2af31250b5a();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_593f1556a13a137f08b3b2af31250b5a() : base() {
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
protected override OSList<RC_b433f1b3ae72f9da85b20eb8b0abb0e8> NewList() {
return new RL_593f1556a13a137f08b3b2af31250b5a();
}


} // RL_593f1556a13a137f08b3b2af31250b5a
}

