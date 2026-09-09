namespace ssConectaProveedores {
/// <summary>
/// [AnonymousStructure] Record (kkjJJiusWE6H5RuDLOssTQ)
///  <code>RC_3ba1d238c8e0f0c3e875fb37f0381cc6</code> that represents <code>OrientationRecord</code
/// > <p>Description: </p>
/// </summary>
// Name: OrientationRecord
public partial struct RC_3ba1d238c8e0f0c3e875fb37f0381cc6 : ITypedRecord<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> {
internal static readonly GlobalObjectKey IdOrientation = GlobalObjectKey.Parse("2UmDmepsh0WSfJ_D1JexCA*ONKhO+DIw_Dodfs38Dgcxg");

public EN_8d4f783227026ce93d50126c7f028443EntityRecord ssENOrientation;


public static implicit operator EN_8d4f783227026ce93d50126c7f028443EntityRecord( RC_3ba1d238c8e0f0c3e875fb37f0381cc6 r) {
return r.ssENOrientation;
}

public static implicit operator RC_3ba1d238c8e0f0c3e875fb37f0381cc6 (EN_8d4f783227026ce93d50126c7f028443EntityRecord r) {
RC_3ba1d238c8e0f0c3e875fb37f0381cc6 res = new RC_3ba1d238c8e0f0c3e875fb37f0381cc6 ();
res.ssENOrientation = r;
return res;
}

public BitArray ChangedAttributes{
set {
    ssENOrientation.ChangedAttributes = value;
}
get {
    return ssENOrientation.ChangedAttributes;
}
}
public BitArray OptimizedAttributes;

public RC_3ba1d238c8e0f0c3e875fb37f0381cc6() {
OptimizedAttributes = null;
ssENOrientation = new EN_8d4f783227026ce93d50126c7f028443EntityRecord();
}

public BitArray[] GetDefaultOptimizedValues(){
    BitArray[] all = new BitArray[1];
    all[0] = new BitArray(1,false);
    return all;
}

public BitArray[] AllOptimizedAttributes{
set{
    if(value == null){
    ssENOrientation.OptimizedAttributes = GetDefaultOptimizedValues()[0];
    }else{
    ssENOrientation.OptimizedAttributes = value[0];
    }
}
get{
    BitArray[] all = new BitArray[1];
    all[0] = ssENOrientation.OptimizedAttributes;
    return all;
}
}

/// <summary>
/// Read a record from database
/// </summary>
/// <param name="r"> Data base reader</param>
/// <param name="index"> index</param>
public void Read( DbDataReader r, ref int index) {
ssENOrientation.Read( r, ref index);
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
public void ReadIM(RC_3ba1d238c8e0f0c3e875fb37f0381cc6 r) {
this = r;
}


public static bool operator == (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 a, RC_3ba1d238c8e0f0c3e875fb37f0381cc6 b) {
if (a.ssENOrientation != b.ssENOrientation) return false;
return true;
}

public static bool operator != (RC_3ba1d238c8e0f0c3e875fb37f0381cc6 a, RC_3ba1d238c8e0f0c3e875fb37f0381cc6 b) {
return !(a==b);
}

public override bool Equals(object o) {
if (o.GetType() != typeof (RC_3ba1d238c8e0f0c3e875fb37f0381cc6)) return false;
return (this == (RC_3ba1d238c8e0f0c3e875fb37f0381cc6)o);
}

public override int GetHashCode() {
try {
return base.GetHashCode()
 ^ ssENOrientation.GetHashCode()
;
} catch {
return base.GetHashCode();
}
}

public void RecursiveReset() {
ssENOrientation.RecursiveReset();
}

public void InternalRecursiveSave() {
ssENOrientation.InternalRecursiveSave();
}


public RC_3ba1d238c8e0f0c3e875fb37f0381cc6 Duplicate() {
RC_3ba1d238c8e0f0c3e875fb37f0381cc6 t;
t.ssENOrientation = (EN_8d4f783227026ce93d50126c7f028443EntityRecord)this.ssENOrientation.Duplicate();
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
if (head == "orientation") {
if (!VarValue.FieldIsOptimized(parent, baseName + ".Orientation")) variable.Value = ssENOrientation; else variable.Optimized = true;
variable.SetFieldName("orientation");
}
if (variable.Found && tail != null) variable.EvaluateFields(this, head, tail);
}

public bool ChangedAttributeGet(GlobalObjectKey key) {
    return ssENOrientation.ChangedAttributeGet(key);
}

public bool OptimizedAttributeGet(GlobalObjectKey key) {
    return ssENOrientation.OptimizedAttributeGet(key);
}

public object AttributeGet(GlobalObjectKey key) {
if (key == IdOrientation) {
return ssENOrientation;
}
throw new Exception("Invalid key");
}
public object GetAttribute(Guid attributeKey) {
if (attributeKey == IdOrientation.Key.AsGuid) {
return ssENOrientation;
}
throw new Exception("Invalid key");
}
public void FillFromOther(IRecord other) {
if (other == null) return;
ssENOrientation.FillFromOther((IRecord) other.AttributeGet(IdOrientation));
}
} // RC_3ba1d238c8e0f0c3e875fb37f0381cc6
/// <summary>
/// RecordList type <code>OrientationRecordList</code> that represents a record list of
///  <code>Orientation</code>
/// </summary>
public partial class RL_1608d9419ce68c1bc879636bc5f915cc : GenericRecordList<RC_3ba1d238c8e0f0c3e875fb37f0381cc6>, IEnumerable, IEnumerator {

protected override RC_3ba1d238c8e0f0c3e875fb37f0381cc6 GetElementDefaultValue() {
return new RC_3ba1d238c8e0f0c3e875fb37f0381cc6();
}

public T[] ToArray<T>(Func<RC_3ba1d238c8e0f0c3e875fb37f0381cc6, T> converter) {
  return ToArray(this, converter);
}

public static T[] ToArray<T>(RL_1608d9419ce68c1bc879636bc5f915cc recordList, Func<RC_3ba1d238c8e0f0c3e875fb37f0381cc6, T> converter) {
  return InnerToArray(recordList, converter);
}
public static implicit operator RL_1608d9419ce68c1bc879636bc5f915cc(RC_3ba1d238c8e0f0c3e875fb37f0381cc6[] array) {
  RL_1608d9419ce68c1bc879636bc5f915cc result = new RL_1608d9419ce68c1bc879636bc5f915cc();
result.InnerFromArray(array);
    return result;
}

public static RL_1608d9419ce68c1bc879636bc5f915cc ToList<T>(T[] array, Func <T, RC_3ba1d238c8e0f0c3e875fb37f0381cc6> converter) {
  RL_1608d9419ce68c1bc879636bc5f915cc result = new RL_1608d9419ce68c1bc879636bc5f915cc();
  result.InnerFromArray(array, converter);
  return result;
}

public static RL_1608d9419ce68c1bc879636bc5f915cc FromRestList<T>(RestList<T> restList, Func <T, RC_3ba1d238c8e0f0c3e875fb37f0381cc6> converter) {
  RL_1608d9419ce68c1bc879636bc5f915cc result = new RL_1608d9419ce68c1bc879636bc5f915cc();
  result.InnerFromRestList(restList, converter);
  return result;
}
public RL_1608d9419ce68c1bc879636bc5f915cc() : base() {
}
public override BitArray[] GetDefaultOptimizedValues(){
BitArray[] def = new BitArray[1];
def[0] = new BitArray(1,false);
return def;
}
/// <summary>
/// Create as new list
/// </summary>
/// <returns>The new record list</returns>
protected override OSList<RC_3ba1d238c8e0f0c3e875fb37f0381cc6> NewList() {
return new RL_1608d9419ce68c1bc879636bc5f915cc();
}


} // RL_1608d9419ce68c1bc879636bc5f915cc
}

